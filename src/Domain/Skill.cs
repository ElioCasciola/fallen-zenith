namespace FallenZenith.Domain;

public class Skill
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int ManaCost { get; private set; }
    public int Damage { get; private set; }
    public DamageType DamageType { get; private set; }

    public Skill(string name, string description, int manaCost, int damage, DamageType damageType)
    {
        Name = name;
        Description = description;
        ManaCost = manaCost;
        Damage = damage;
        DamageType = damageType;
    }
}
