using FallenZenith.Entities;

namespace FallenZenith.Skills
{
    internal class Fireball : Skill
    {
        public Fireball()
            : base("Fireball", "Launches a powerful ball of fire", 15) 
        {
        }

        protected override int ApplyEffect(Entity user, Entity target)
        {
            int damage = user.ATT + 10 - target.DEF;

            return target.TakeDamage(damage);
        }
    }
}
