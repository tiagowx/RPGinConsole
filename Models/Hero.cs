using RPGinConsole.Models.Abstracts;
using RPGinConsole.Models.Enums;

namespace RPGinConsole.Models
{
  public class Hero : Character
  {
    public Hero(string _name, CharClasses charClass)
    {
      social.SetName(_name);
      social.SetCharClass(charClass);

      switch (charClass)
      {
        case CharClasses.PALADIN:
          this.SetStatus(0, 0, 0, 0, 0, 0);
          break;
        case CharClasses.HUNTER:
          this.SetStatus(0, 0, 0, 0, 0, 0);
          break;
        case CharClasses.MAGE:
          this.SetStatus(0, 0, 0, 0, 0, 0);
          break;
        case CharClasses.CLERIG:
          this.SetStatus(0, 0, 0, 0, 0, 0);
          break;
      }
      Console.WriteLine($"{social.name} foi criada com sucesso e pertence a classe {social.charClass}.");

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