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
        string line = $"({i + 1}) - {heroes[i].social.name}({heroes[i].social.charClass})";
        line += $"[HP:{heroes[i].constitution.hp}/{heroes[i].constitution.maxHp}]";
        line += $" [MP:{heroes[i].mentality.mp}/{heroes[i].mentality.maxMp}]";
        Console.WriteLine(line);
      }
    }
    public void EnemyRender(List<Enemy> enemies)
    {
      Console.WriteLine("\n Hérois:");
      for (int i = 0; i < enemies.Count; i++)
      {
        string line = $"({i + 1}) - {enemies[i].social.name}({enemies[i].social.charClass})";
        line += $"[HP:{enemies[i].constitution.hp}/{enemies[i].constitution.maxHp}]";
        line += $" [MP:{enemies[i].mentality.mp}/{enemies[i].mentality.maxMp}]";
        Console.WriteLine(line);
      }
    }
    public void HeroStatusRender(List<Hero> heroes, int i)
    {
      Console.Clear();
      Console.WriteLine("---STATUS--- \n");
      string status = $"({i + 1})";
      status += $" {heroes[i].social.name}";
      status += $" Lv.{heroes[i].social.level}";
      status += $" ({heroes[i].social.charClass})";
      status += $"\n STR {heroes[i].strenght.value}";
      status += $"\n\t dano físico {heroes[i].strenght.damage}";
      status += $"\n CON {heroes[i].constitution.value}";
      status += $"\n\t defesa física {heroes[i].constitution.def}";
      status += $"\n DEX {heroes[i].dexterity.value}";
      status += $"\n\t chance de crítico {heroes[i].dexterity.criticalChance}";
      status += $"\n INT {heroes[i].inteligence.value}";
      status += $"\n\t dano mágico {heroes[i].inteligence.magicDamage}";
      status += $"\n MEN {heroes[i].mentality.value}";
      status += $"\n\t defesa mágica {heroes[i].mentality.magicDef}";
      status += $"\n WIT {heroes[i].wit.value}";
      status += $"\n\t chance de obliterar {heroes[i].wit.chanceOverHit}";
      Console.WriteLine(status);

      Console.WriteLine("\n Pressione qualquer tecla para voltar.");
    }
    public void BestiariRender(List<Enemy> enemies)
    {
      Console.Clear();
      Console.WriteLine($"# \t Nome \t\t\t STR \t CON \t DEX \t INT \t MEN \t WIT \n");
      for (int i = 0; i < enemies.Count; i++)
      {
        string enemy = $"({i + 1})";
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