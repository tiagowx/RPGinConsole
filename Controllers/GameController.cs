using RPGinConsole.Models;
using RPGinConsole.Models.Enums;
using RPGinConsole.Views;

namespace RPGinConsole.Controllers
{
  public class GameController
  {
    public Hero hero;
    public List<Enemy> enemies = new List<Enemy>();
    public Map local = Map.FLORESTA;

    public Render views = new Render();

    public string message;
    public void Begin(string? message)
    {
      Console.Clear();

      views.BeginRender();

      if (!string.IsNullOrEmpty(message))
      {
        Console.WriteLine(message);
      }


      Console.Write("\n Sua escolha: ");
      string choiceHero = CheckChoices(Console.ReadLine(), 3);

      switch (choiceHero)
      {
        case "1":
          BattleMode(null);
          break;
        case "2":
          Tutorial(null);
          break;
        case "3":
          Credits(null);
          break;
        case "0":
          Console.Clear();
          Console.WriteLine("Obrigado por jogar!");
          Console.ReadLine();
          break;
        default:
          Begin("Mensagem: Digite uma escolha válida.");
          break;
      }
    }

    public void HeroCreate(string? message)
    {
      Console.Clear();
      Console.WriteLine("\t Escolha a classe de seu héroi.");
      Console.WriteLine("\t\t 1- Paladino");
      Console.WriteLine("\t\t 2- Caçador");
      Console.WriteLine("\t\t 3- Maga");
      Console.WriteLine("\t\t 4- Clériga \n");

      if (!string.IsNullOrEmpty(message))
      {
        Console.WriteLine(message);
      }

      Console.Write("\n Sua escolha: ");
      string choiceHero = Console.ReadLine();

      if (string.IsNullOrEmpty(choiceHero)) HeroCreate("\n Menssagem: Voxê não digitou sua escolha de classe.");

      Console.Write("\n Escreva o nome dele(a): ");
      string heroName = Console.ReadLine();

      if (string.IsNullOrEmpty(heroName)) HeroCreate("\n Menssagem: O nome do personagem não pode ser vazio.");


      switch (choiceHero)
      {
        case "1":
          hero = new Hero(heroName, CharClasses.PALADIN);
          break;
        case "2":
          hero = new Hero(heroName, CharClasses.HUNTER);
          break;
        case "3":
          hero = new Hero(heroName, CharClasses.MAGE);
          break;
        case "4":
          hero = new Hero(heroName, CharClasses.CLERIG);
          break;
        default:
          HeroCreate("Mensagem: Digite uma opção válida. \n");
          break;
      }
      Context();
    }

    public void Tutorial(string? message)
    {
      Console.Clear();

      Console.WriteLine("--- TUTORIAL --- \n");
      // Instruções


      Console.WriteLine("0- Voltar");

      if (!string.IsNullOrEmpty(message))
      {
        Console.WriteLine(message);
      }

      Console.Write("\n Sua escolha: ");
      string choice = Console.ReadLine();

      if (choice == "0")
        Begin(null);
      else
        Tutorial("Mensagem: Digite uma opção válida. \n");
    }

    public void Credits(string? message)
    {
      Console.Clear();
      Console.WriteLine("--- CREDITOS --- \n");
      // 


      Console.WriteLine("0- Voltar");

      if (!string.IsNullOrEmpty(message))
      {
        Console.WriteLine(message);
      }

      Console.Write("\n Sua escolha: ");
      string choice = Console.ReadLine();

      if (choice == "0")
        Begin(null);
      else
        Begin("Mensagem: Digite uma opção válida. \n ");
    }
    public void Context()
    {
      Console.Clear();
      Console.WriteLine("Contexto: ");
      Console.WriteLine($"\nLocal: {local}");
      Console.WriteLine($"Ameaças proximas: {enemies.Count}");
      Console.WriteLine("\nSeu heroi:");
      Console.WriteLine(@$"{hero.social.name}({hero.social.charClass}) 
        HP: ({hero.constitution.hp}/{hero.constitution.maxHp}) 
        MP: ({hero.mentality.mp}/{hero.mentality.maxMp}) 
      ");
      Console.WriteLine("\nAções:");
      Console.WriteLine("\t 1- Seguir em frente");
      Console.WriteLine("\t 2- Observar");
      Console.WriteLine("\t 3- Status do héroi");
      Console.WriteLine("\t 4- Atacar ameaça");
      Console.WriteLine("\t 0- Voltar");

      Console.Write("\n Sua escolha: ");
      string choice = Console.ReadLine();

      if (choice == "0")
        Begin(null);
      else
        Begin("Mensagem: Digite uma opção válida. \n ");

      switch (choice)
      {
        case "1":
          break;
        case "2":
          break;
        case "3":
          break;
        case "4":
          break;
        case "0":
          break;
      }
    }

    public List<Hero> heroes = new List<Hero>();
    public void BattleMode(string? message)
    {
      if (heroes.Count == 0)
      {
        heroes.Add(new Hero("Mário", CharClasses.PALADIN));
        heroes.Add(new Hero("Samira", CharClasses.HUNTER));
        heroes.Add(new Hero("Sirius", CharClasses.MAGE));
        heroes.Add(new Hero("Bárbara", CharClasses.CLERIG));
      }

      Console.Clear();
      Console.WriteLine($"\nLocal: {local}");
      Console.WriteLine("\n Hérois:");
      for (int i = 0; i < heroes.Count; i++)
      {
        Console.WriteLine($@"({i + 1}) - {heroes[i].social.name}({heroes[i].social.charClass})
        [HP:{heroes[i].constitution.hp}/{heroes[i].constitution.maxHp}] ");
      }
      Console.WriteLine("\n Inimigos:");
      Console.WriteLine("\n Ações: (1) Atacar; (2) Usar Habilidade; (3) Ver Status; (4) Fugir;");

      if (!string.IsNullOrEmpty(message))
      {
        Console.WriteLine($"\n{message}");
      }

      Console.Write("\n Sua escolha: ");
      string choice = Console.ReadLine();

      switch (choice)
      {
        case "1": // Atacar
          break;
        case "2": // Usar habilidade
          break;
        case "3": // Status
          views.HeroStatusRender(heroes);
          Console.Read();
          BattleMode(null);
          break;
        case "4": // Fugir
          break;
        default:
          BattleMode("Mensagem: Digite uma opção válida.");
          break;
      }
    }

    public void BasicAtack(string? message)
    {
      if (!string.IsNullOrEmpty(message))
      {
        Console.WriteLine($"\n{message}");
      }

      Console.Write("Digite o número do heroi que deseja usar para atacar: ");
      string selected = Console.ReadLine();


      Console.WriteLine("Digite o número do heroi que deseja usar para atacar.' ");
    }

    public string CheckChoices(string? choice, int ofChoices)
    {
      if (choice.Length > 1)
        return "";

      int n = Int32.Parse(choice);
      if (n >= 0 && n <= ofChoices)
        return choice;

      return "";
    }

  }

}