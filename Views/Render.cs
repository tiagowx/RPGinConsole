using RPGinConsole.Controllers;
using RPGinConsole.Models;

namespace RPGinConsole.Views
{
  public class Render
  {
    public void BeginRender()
    {
      Console.WriteLine("--- BEM VINDO --- \n");
      Console.WriteLine("Para jogar digite um número referente a um item do Menu. \n");
      Console.WriteLine("Menu: \n");
      Console.WriteLine("\t 1- Jogar \n");
      Console.WriteLine("\t 2- Tutorial \n");
      Console.WriteLine("\t 3- Créditos \n");
      Console.WriteLine("\t 0- Sair do Jogo \n");
    }

    public void HeroRender(List<Hero> heroes)
    {
      Console.WriteLine("\n Hérois:");
      for (int i = 0; i < heroes.Count; i++)
      {
        Console.WriteLine($@"({i + 1}) - {heroes[i].social.name}({heroes[i].social.charClass})
        [HP:{heroes[i].constitution.hp}/{heroes[i].constitution.maxHp}] 
        [MP:{heroes[i].mentality.mp}/{heroes[i].mentality.maxMp}] 
        ");
      }
    }
    public void EnemyRender(List<Enemy> enemies)
    {
      Console.WriteLine("\n Hérois:");
      for (int i = 0; i < enemies.Count; i++)
      {
        Console.WriteLine($@"({i + 1}) - {enemies[i].social.name}({enemies[i].social.charClass})
        [HP:{enemies[i].constitution.hp}/{enemies[i].constitution.maxHp}] 
        [MP:{enemies[i].mentality.mp}/{enemies[i].mentality.maxMp}] 
        ");
      }
    }
    public void HeroStatusRender(List<Hero> heroes)
    {
      Console.Clear();
      Console.WriteLine($"# \t Nome \t\t\t STR \t CON \t DEX \t INT \t MEN \t WIT \n");
      for (int i = 0; i < heroes.Count; i++)
      {
        string line = $"({i+1})";
        line += $"\t{heroes[i].social.name}";
        line += $"({heroes[i].social.charClass})";
        line += $"\t\t  {heroes[i].strenght.value}";
        line += $"\t  {heroes[i].constitution.value}";
        line += $"\t  {heroes[i].dexterity.value}";
        line += $"\t  {heroes[i].inteligence.value}";
        line += $"\t  {heroes[i].mentality.value}";
        line += $"\t  {heroes[i].wit.value}";
        Console.WriteLine(line);
      }
      Console.WriteLine("\n Pressione qualquer tecla para voltar.");
    }
    public void BestiariRender(List<Enemy> enemies)
    {
      Console.Clear();
      Console.WriteLine($"# \t Nome \t\t\t STR \t CON \t DEX \t INT \t MEN \t WIT \n");
      for (int i = 0; i < enemies.Count; i++)
      {
        string enemy = $"({i+1})";
        enemy += $"\t{enemies[i].social.name}";
        enemy += $"({enemies[i].social.charClass})";
        enemy += $"\t\t  {enemies[i].strenght.value}";
        enemy += $"\t  {enemies[i].constitution.value}";
        enemy += $"\t  {enemies[i].dexterity.value}";
        enemy += $"\t  {enemies[i].inteligence.value}";
        enemy += $"\t  {enemies[i].mentality.value}";
        enemy += $"\t  {enemies[i].wit.value}";
        Console.WriteLine(enemy);
      }
      Console.WriteLine("\n Pressione qualquer tecla para voltar.");
    }
   
  }
}