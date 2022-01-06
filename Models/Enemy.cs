using RPGinConsole.Models.Abstracts;
using RPGinConsole.Models.Enums;

namespace RPGinConsole.Models
{
  public class Enemy : Character
  {
    public Enemy(string _name, CharClasses charClass)
    {
      social.SetName(_name);
      social.SetCharClass(charClass);

      switch (charClass)
      {
        case CharClasses.PALADIN:
          this.SetStatus(5, 9, 3, 3, 7, 3);
          break;
        case CharClasses.HUNTER:
          this.SetStatus(6, 5, 9, 3, 4, 3);
          break;
        case CharClasses.MAGE:
          this.SetStatus(3, 4, 3, 9, 6, 6);
          break;
        case CharClasses.CLERIG:
          this.SetStatus(3, 6, 3, 5, 8, 5);
          break;
      }
      this.social.SetLevel(1);
      this.RefreshSubstatus();
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