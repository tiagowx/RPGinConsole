using RPGinConsole.Models.Abstracts;
using RPGinConsole.Models.Enums;

namespace RPGinConsole.Models
{
  public class Enemy : Character
  {
    public Enemy(string _name, CharClasses charClass)
    {
      this.social.SetName(_name);
      this.social.SetCharClass(charClass);

      switch (charClass)
      {
        case CharClasses.PALADIN:
          this.SetStatus(0,0,0,0,0,0);
        break;
        case CharClasses.HUNTER:
          this.SetStatus(0,0,0,0,0,0);
        break;
        case CharClasses.MAGE:
          this.SetStatus(0,0,0,0,0,0);
        break;
        case CharClasses.CLERIG:
          this.SetStatus(0,0,0,0,0,0);
        break;

      }

    }

    public override void Attack()
    {
      Console.WriteLine($"Atacou e causo dano em ");
    }

    public override void Skill()
    {
      Console.WriteLine($"Usou sua habilidade em ");
    }

    public override void Ultimate()
    {
      Console.WriteLine($"Usou a ultimate em ");
    }
  }
}