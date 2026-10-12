namespace FallenZenith.Domain;

public class Character
{
    public int HP { get; private set; }
    public int MaxHP { get; private set; }
    public int MP { get; private set; }
    public int MaxMP { get; private set; }
    public int PhysicalAttack { get; private set; }
    public int Strength { get; private set; }
    public int MagicalAttack { get; private set; }
    public int Intelligence { get; private set; }
    public int Defense { get; private set; }
    public int MagicDefense { get; private set; }
    public int Speed { get; private set; }
    public int CriticalChance { get; private set; }
    public int Level { get; private set; }
    public int Experience { get; private set; }
    public List<Skill> Skills { get; private set; }

    public Character(
        int hp, int maxHP,
        int mp, int maxMP,
        int physicalattack,
        int strength,
        int magicalattack,
        int intelligence,
        int defense,
        int magicDefense,
        int speed,
        int criticalChance,
        int level,
        int experience,
        List<Skill> skills)
    {
        HP = hp;
        MaxHP = maxHP;
        MP = mp;
        MaxMP = maxMP;
        PhysicalAttack = physicalattack;
        Strength = strength;
        MagicalAttack = magicalattack;
        Intelligence = intelligence;
        Defense = defense;
        MagicDefense = magicDefense;
        Speed = speed;
        CriticalChance = criticalChance;
        Level = level;
        Experience = experience;
        Skills = skills;
    }

    public void TakeDamage(int damage)
    {
        if(damage <= 0)
        {
            return;
        }
        else
        {
            HP -= damage;
        }

        if(HP<0)
        {
            HP = 0;
        }
    }
}
