using RPGinConsole.Models.Abstracts;

namespace RPGinConsole.Models
{
  public class Enemy : Character
  {
    public override void Attack()
    {
        Console.WriteLine($"Atacou e causo dano em ");
    }

    public override void Skill()
    {
        Console.WriteLine($"Usou sua habilidade em ");
    }

    public override void Ultimate() { 
        Console.WriteLine($"Usou a ultimate em ");
    }
  }
}