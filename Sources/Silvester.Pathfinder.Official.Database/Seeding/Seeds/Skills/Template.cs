using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Skills
{
    public abstract class Template : EntityTemplate<Skill>
    {
        protected override Skill GetEntity(ModelBuilder builder)
        {
            Skill skill = GetSkill();
            return skill;
        }

        public abstract Skill GetSkill();
    }
}
