using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DivineFonts
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
