using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Proficiencies
{
    public abstract class Template : EntityTemplate<Proficiency>
    {
        protected override Proficiency GetEntity(ModelBuilder builder)
        {
            Proficiency proficiency = GetProficiency();
            return proficiency;
        }

        public abstract Proficiency GetProficiency();
    }
}
