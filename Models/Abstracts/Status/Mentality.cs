namespace RPGinConsole.Models.Abstracts.Status
{
  public abstract partial class Character
  {
    public class Mentality
    {
      public int value { get; private set; }
      public int magicDef { get; private set; }
      public int maxMp { get; private set; }
      public int mp { get; private set; }

      public void AddPoint() => value++;
      public void AddPoint(int points) => value = points;
      public void SetMaxMp(int v) => maxMp = v;
      public void SetMp(int v) => mp = v;
      public void SetMagicDef(int v) => magicDef = v;
    }
  }
}