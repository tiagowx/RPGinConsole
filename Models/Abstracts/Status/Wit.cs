namespace RPGinConsole.Models.Abstracts.Status
{
  public abstract partial class Character
  {
    public class Wit
    {
      public int value { get; private set; }
      public float chanceOverHit { get; private set; }

      public void SetChanceOverHit(float v) => chanceOverHit = v;

      public void AddPoint() => value++;
      public void AddPoint(int points) => value = points;
    }
  }
}