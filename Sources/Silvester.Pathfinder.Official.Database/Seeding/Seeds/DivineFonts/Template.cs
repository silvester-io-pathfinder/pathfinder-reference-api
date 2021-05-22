using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.DivineFonts
{
    public abstract class Template : EntityTemplate<DivineFont>
    {
        protected override DivineFont GetEntity(ModelBuilder builder)
        {
            DivineFont font = GetDivineFont();
            return font;
        }

        protected abstract DivineFont GetDivineFont();
    }
}
