namespace RPGinConsole.Models.Abstracts.Status
{
  public abstract partial class Character
  {
    public class Dexterity{
      public int value {get; private set;}
      public float criticalChance {get; private set;}
      public void AddPoint() => value++;
      public void AddPoint(int points) => value = points;
      public void SetCritical(float v) => criticalChance = v;
    }
  }
}