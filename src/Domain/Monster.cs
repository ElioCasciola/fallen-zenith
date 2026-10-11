namespace FallenZenith.Domain;

public class Monster
{
    public string Name { get; private set; }
    public int HP { get; private set; }
    public int MaxHP { get; private set; }
    public int MP { get; private set; }
    public int MaxMP { get; private set; }
    public int Strength { get; private set; }
    public int Intelligence { get; private set; }
    public int Defense { get; private set; }
    public int MagicDefense { get; private set; }
    public int Speed { get; private set; }
    public int CriticalChance { get; private set; }
    public int Level { get; private set; }
    public List<Skill> Skills { get; private set; }

    public Monster(
        string name,
        int hp, int maxHP,
        int mp, int maxMP,
        int strength,
        int intelligence,
        int defense,
        int magicDefense,
        int speed,
        int criticalChance,
        int level,
        List<Skill> skills)
    {
        Name = name;
        HP = hp;
        MaxHP = maxHP;
        MP = mp;
        MaxMP = maxMP;
        Strength = strength;
        Intelligence = intelligence;
        Defense = defense;
        MagicDefense = magicDefense;
        Speed = speed;
        CriticalChance = criticalChance;
        Level = level;
        Skills = skills;
    }
}
