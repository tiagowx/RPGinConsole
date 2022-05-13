using static RPGinConsole.Models.Abstracts.Status.Character;

namespace RPGinConsole.Models.Abstracts
{
  public abstract partial class Character
  {
    public Social social = new Social();
    public Strenght strenght = new Strenght();
    public Constitution constitution = new Constitution();
    public Dexterity dexterity = new Dexterity();
    public Inteligence inteligence = new Inteligence();
    public Mentality mentality = new Mentality();
    public Wit wit = new Wit();
    public void RefreshSubstatus()
    {
      //STR
      strenght.SetDamage(strenght.value * 2 + social.level);
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
    public void SetStatus(int _str, int _con, int _dex, int _int, int _men, int _wit)
    {
      this.strenght.AddPoint(_str);
      this.constitution.AddPoint(_con);
      this.dexterity.AddPoint(_dex);
      this.inteligence.AddPoint(_int);
      this.mentality.AddPoint(_men);
      this.wit.AddPoint(_wit);

    }
    public void ShowStatus()
    {
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