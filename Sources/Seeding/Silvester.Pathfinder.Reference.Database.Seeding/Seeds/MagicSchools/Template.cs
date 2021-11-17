using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MagicSchools
{
    public abstract class Template : EntityTemplate<MagicSchool>
    {
        protected override MagicSchool GetEntity(ISeedBuilder builder)
        {
            MagicSchool school = GetMagicSchool();
            return school;
        }

        protected abstract MagicSchool GetMagicSchool();
    }
}
