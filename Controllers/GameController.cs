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
      int choiceHero = CheckChoices(Console.ReadLine(), 3);

      switch (choiceHero)
      {
        case 1:
          BattleMode(null);
          break;
        case 2:
          Tutorial(null);
          break;
        case 3:
          Credits(null);
          break;
        case 0:
          Console.Clear();
          Console.WriteLine("Obrigado por jogar!");
          Console.ReadLine();
          break;
        default:
          Begin("Mensagem: Digite uma escolha válida.");
          break;
      }
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

      SpownEnemy();

      Console.Clear();
      Console.WriteLine($"\nLocal: {local}");
      Console.WriteLine("\n Hérois:");
      views.HeroRender(heroes);

      Console.WriteLine("\n Inimigos:");
      views.EnemyRender(enemies);

      Console.WriteLine("\n Ações: (1) Atacar; (2) Usar Habilidade; (3) Ver Status; (4) Fugir;");

      if (!string.IsNullOrEmpty(message))
      {
        Console.WriteLine($"\n{message}");
      }

      Console.Write("\n Sua escolha: ");
      int choice = CheckChoices(Console.ReadLine(), 4);

      switch (choice)
      {
        case 1:
          BasicAtack(null);
          break;
        case 2: // Usar habilidade
          break;
        case 3: // Status
          Console.WriteLine("Escolha o héroi:");
          int i = CheckChoices(Console.ReadLine(), heroes.Count);
          views.HeroStatusRender(heroes, i - 1);
          Console.Read();
          BattleMode(null);
          break;
        case 4: // Fugir
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

      Console.Write("Digite o número do heroi atacante: ");
      int heroSelected = CheckChoices(Console.ReadLine(), heroes.Count);

      Console.Write("Digite o número do alvo: ");
      int enemySelected = CheckChoices(Console.ReadLine(), enemies.Count);

      BattleMode($"{heroes[heroSelected - 1].social.name} atacou e causou {enemies[enemySelected - 1].constitution.ReceiveDamage(heroes[heroSelected - 1].strenght.damage)}");
    }

    public void SpownEnemy()
    {
      if (enemies.Count == 0)
      {
        enemies.Add(new Enemy("Slime", CharClasses.CLERIG));
      }
    }

    public int CheckChoices(string? choice, int ofChoices)
    {

      if (choice.Length > 1 || string.IsNullOrEmpty(choice))
        return 9;

      int n = Int32.Parse(choice);
      if (n >= 0 && n <= ofChoices)
        return n;

      return 9;
    }

  }

}