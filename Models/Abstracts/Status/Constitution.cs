namespace RPGinConsole.Models.Abstracts.Status
{
  public abstract partial class Character
  {
    public class Constitution
    {
      public int value { get; private set; }
      public int maxHp { get; private set; }
      public int hp { get; private set; }
      public int def { get; private set; }

      public void AddPoint() => value++;
      public void AddPoint(int points) => value = points;

      public int ReceiveDamage(int _damage)
      {
        int dmg = _damage - def;
        hp -= dmg;
        return dmg;
      }
      public void SetMaxHp(int v) => maxHp = v;
      public void SetHp(int v) => hp = v;

      public void SetDef(int v) => def = v;
    }
  }
}