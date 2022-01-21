using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes
{
    public abstract class Template : EntityTemplate<DamageType>
    {
        protected override DamageType GetEntity(ISeedBuilder builder)
        {
            DamageType damageType = GetAction();
            return damageType;
        }

        protected abstract DamageType GetAction();
    }
}
