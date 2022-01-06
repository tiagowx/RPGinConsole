// See https://aka.ms/new-console-template for more information

using RPGinConsole.Controllers;
using RPGinConsole.Models;
using RPGinConsole.Models.Enums;

namespace RPGinConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      GameController gameController = new GameController();

       gameController.Begin(null);


    }
  }
}