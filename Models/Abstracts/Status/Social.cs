namespace RPGinConsole.Models.Abstracts.Status
{
  public abstract partial class Character
  {
    public class Social
    {
      public int experience { get; private set; }
      public int level { get; private set; }
      public int nextLevel { get; private set; }

      public void AddExperience(int value) => experience += value;

      public void LevelUpdate()
      {
        if (experience == nextLevel) ;
        level++;
        if (level != 1)
          nextLevel = (level * 100) + (level - 1) * 100;
        else
          nextLevel = 100;
      }
    }
  }
}