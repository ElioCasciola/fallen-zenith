using FallenZenith.Entities;

namespace FallenZenith.Skills
{
    internal class PowerStrike : Skill
    {
        public PowerStrike()
            : base("Power Strike", "Delivers a powerful strike with double attack power.", 10)
        {
        }

        protected override int ApplyEffect(Entity user, Entity target)
        {
            int damage = user.ATT * 2 - target.DEF;

            return target.TakeDamage(damage);
        }
    }
}
