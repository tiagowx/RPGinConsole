using static RPGinConsole.Models.Abstracts.Status.Character;

namespace RPGinConsole.Models.Abstracts
{
  public abstract partial class Character
  {
    public Strenght strenght;
    public Constitution constitution;
    public Dexterity dexterity;
    public Inteligence inteligence;
    public Mentality mentality;
    public Wit wit;
    public Social social;
    public void RefreshSubstatus()
    {
      //STR
      strenght.SetDamage(strenght.value + social.level);
      //CON
      constitution.SetDef(constitution.value + strenght.value);
      constitution.SetMaxHp(constitution.value * social.level * 3);
      constitution.SetHp(constitution.maxHp);
      //DEX
      dexterity.SetCritical(dexterity.value / social.level);
      //INT
      inteligence.SetDamage(inteligence.value + social.level);
      //MEN
      mentality.SetMagicDef(mentality.value + inteligence.value);
      mentality.SetMaxMp(mentality.value * social.level * 3);
      mentality.SetMp(mentality.maxMp);
      //WIT
      wit.SetChanceOverHit(wit.value / social.level);
    }

    public abstract void Attack();
    public abstract void Skill();
    public abstract void Ultimate();
    public void ShowStatus(){
      Console.WriteLine("Status");
      Console.WriteLine($"STR: {strenght.value}");
      Console.WriteLine($"CON: {constitution.value}");
      Console.WriteLine($"DEX: {dexterity.value}");
      Console.WriteLine($"INT: {inteligence.value}");
      Console.WriteLine($"MEN: {mentality.value}");
      Console.WriteLine($"WIT: {wit.value}");
    }
  }
}