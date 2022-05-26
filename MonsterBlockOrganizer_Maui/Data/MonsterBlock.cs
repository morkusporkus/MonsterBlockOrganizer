namespace MonsterBlockOrganizer_Maui.Data;


public class MonsterBlock
{
    public string name { get; set; }
    public string size { get; set; }
    public string type { get; set; }
    public string tag { get; set; }
    public string alignment { get; set; }
    public int hitDice { get; set; }
    public string armorName { get; set; }
    public int shieldBonus { get; set; }
    public int natArmorBonus { get; set; }
    public string otherArmorDesc { get; set; }
    public int speed { get; set; }
    public int burrowSpeed { get; set; }
    public int climbSpeed { get; set; }
    public int flySpeed { get; set; }
    public bool hover { get; set; }
    public int swimSpeed { get; set; }
    public bool customHP { get; set; }
    public bool customSpeed { get; set; }
    public string hpText { get; set; }
    public string speedDesc { get; set; }
    public int strPoints { get; set; }
    public int dexPoints { get; set; }
    public int conPoints { get; set; }
    public int intPoints { get; set; }
    public int wisPoints { get; set; }
    public int chaPoints { get; set; }
    public int blindsight { get; set; }
    public bool blind { get; set; }
    public int darkvision { get; set; }
    public int tremorsense { get; set; }
    public int truesight { get; set; }
    public int telepathy { get; set; }
    public string cr { get; set; }
    public string customCr { get; set; }
    public int customProf { get; set; }
    public bool isLegendary { get; set; }
    public string legendariesDescription { get; set; }
    public bool isLair { get; set; }
    public string lairDescription { get; set; }
    public string lairDescriptionEnd { get; set; }
    public bool isRegional { get; set; }
    public string regionalDescription { get; set; }
    public string regionalDescriptionEnd { get; set; }
    public object[] properties { get; set; }
    public Ability[] abilities { get; set; }
    public Action[] actions { get; set; }
    public object[] reactions { get; set; }
    public object[] legendaries { get; set; }
    public object[] lairs { get; set; }
    public object[] regionals { get; set; }
    public Sthrow[] sthrows { get; set; }
    public Skill[] skills { get; set; }
    public Damagetype[] damagetypes { get; set; }
    public Specialdamage[] specialdamage { get; set; }
    public Condition[] conditions { get; set; }
    public Language[] languages { get; set; }
    public string understandsBut { get; set; }
    public string shortName { get; set; }
    public bool doubleColumns { get; set; }
    public int separationPoint { get; set; }
    public object[] damage { get; set; }
    public string pluralName { get; set; }
    public bool ShowDetails { get; set; }
}
public class Ability
{
    public string name { get; set; }
    public string desc { get; set; }
}
public class Action
{
    public string name { get; set; }
    public string desc { get; set; }
}
public class Sthrow
{
    public string name { get; set; }
    public int order { get; set; }
}
public class Skill
{
    public string name { get; set; }
    public string stat { get; set; }
}
public class Damagetype
{
    public string name { get; set; }
    public string note { get; set; }
    public string type { get; set; }
}
public class Specialdamage
{
    public string name { get; set; }
    public string note { get; set; }
    public string type { get; set; }
}
public class Condition
{
    public string name { get; set; }
}
public class Language
{
    public string name { get; set; }
    public bool speaks { get; set; }
}
