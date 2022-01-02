using RPGinConsole.Models;
using RPGinConsole.Models.Enums;

namespace RPGinConsole.Controllers
{
  public class GameController
  {
    public static Hero hero;
    public void Begin()
    {
      Console.Clear();
      Console.WriteLine("--- BEM VINDO ---");
      Console.WriteLine("Para jogar digite um numero referente a um item do Menu de escolhas. \n");
      Console.WriteLine("Menu: \n");
      Console.WriteLine("\t Escolha a classe de seu héroi");
      Console.WriteLine("\t\t 1- Paladino");
      Console.WriteLine("\t\t 2- Caçador");
      Console.WriteLine("\t\t 3- Maga");
      Console.WriteLine("\t\t 4- Clériga \n");
      Console.Write("Sua escolha: ");
      string choiceHero = Console.ReadLine();
      Console.Write("\n Escreva o nome dele(a): ");
      string heroName = Console.ReadLine();

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
          Begin(choiceHero);
          break;
      }
    }

    public void Begin(string choice)
    {

      Console.WriteLine($"Mensagem: '{choice}' não é uma opção válida");
      Begin();

    }
  }
}