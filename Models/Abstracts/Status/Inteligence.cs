namespace RPGinConsole.Models.Abstracts.Status
{
  public abstract partial class Character
  {
    public class Inteligence{
      public int value { get; private set;}
      public int magicDamage { get; private set;}
      public void AddPoint() => value++;
      public void AddPoint(int points) => value = points;
      public void SetDamage(int v) => magicDamage = v;
    }
  }
}