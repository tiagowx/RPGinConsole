using RPGinConsole.Models.Enums;
namespace RPGinConsole.Models.Abstracts.Status
{
  public abstract partial class Character
  {
    public class Social
    {
      public string name { get; private set; }
      public CharClasses charClass { get; private set; }
      public int experience { get; private set; }
      public int level { get; private set; }
      public int nextLevel { get; private set; }

      public int AddExperience(int value) => experience += value;

      public void LevelUpdate()
      {
        if (experience == nextLevel) level++;
        
        if (level != 1)
          nextLevel = (level * 100) + (level - 1) * 100;
        else
          nextLevel = 100;
      }

      public void SetName(string _name) => this.name = _name;
      public void SetCharClass(CharClasses charClasses) => this.charClass = charClass;
      public void SetLevel(int lvl) => level = lvl;
    }
  }
}