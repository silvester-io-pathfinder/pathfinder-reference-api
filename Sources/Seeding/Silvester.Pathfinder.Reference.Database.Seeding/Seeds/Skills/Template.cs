using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Skills
{
    public abstract class Template : EntityTemplate<Skill>
    {
        protected override Skill GetEntity(ISeedBuilder builder)
        {
            Skill skill = GetSkill();
            return skill;
        }

        public abstract Skill GetSkill();
    }
}
