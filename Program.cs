// See https://aka.ms/new-console-template for more information

using RPGinConsole.Models;

namespace RPGinConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      Enemy enemies = new Enemy();

      enemies.constitution.AddPoint();
      enemies.Attack();
    }
  }
}