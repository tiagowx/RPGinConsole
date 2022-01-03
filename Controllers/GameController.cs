using RPGinConsole.Models;
using RPGinConsole.Models.Enums;

namespace RPGinConsole.Controllers
{
  public class GameController
  {
    public Hero hero;
    public Enemy[] enemies;

    public string message;
    public void Begin(string? message)
    {
      Console.Clear();
      Console.WriteLine("--- BEM VINDO --- \n");
      Console.WriteLine("Para jogar digite um número referente a um item do Menu. \n");
      Console.WriteLine("Menu: \n");
      Console.WriteLine("\t 1- Jogar \n");
      Console.WriteLine("\t 2- Tutorial \n");
      Console.WriteLine("\t 3- Créditos \n");

      if (!string.IsNullOrEmpty(message))
      {
        Console.WriteLine(message);
      }


      Console.Write("\n Sua escolha: ");
      string choiceHero = Console.ReadLine();

      switch (choiceHero)
      {
        case "1":
          HeroCreate(null);
          break;
        case "2":
          Tutorial(null);
          break;
        case "3":
          Credits(null);
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
      // Instruções


      Console.WriteLine("0- Voltar");

      if (!string.IsNullOrEmpty(message))
      {
        Console.WriteLine(message);
      }

      Console.Write("\n Sua escolha: ");
      string choiceHero = Console.ReadLine();
    }
  }
}