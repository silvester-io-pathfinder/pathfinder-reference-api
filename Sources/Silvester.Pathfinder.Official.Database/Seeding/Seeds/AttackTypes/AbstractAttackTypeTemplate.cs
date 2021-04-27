using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AttackTypes
{
    public abstract class AbstractAttackTypeTemplate : EntityTemplate<AttackType>
    {
        protected override AttackType GetEntity(ModelBuilder builder)
        {
            AttackType type = GetAttackType();
            return type;
        }

        protected abstract AttackType GetAttackType();
    }
}
