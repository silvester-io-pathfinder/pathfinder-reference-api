using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Proficiencies
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
