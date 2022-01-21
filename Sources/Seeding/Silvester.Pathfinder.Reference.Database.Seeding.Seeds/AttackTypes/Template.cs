using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AttackTypes
{
    public abstract class Template : EntityTemplate<AttackType>
    {
        protected override AttackType GetEntity(ISeedBuilder builder)
        {
            AttackType type = GetAttackType();
            return type;
        }

        protected abstract AttackType GetAttackType();
    }
}
