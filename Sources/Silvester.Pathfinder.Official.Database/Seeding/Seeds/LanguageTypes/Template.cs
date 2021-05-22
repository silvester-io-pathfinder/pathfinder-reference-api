using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.LanguageTypes
{
    public abstract class Template : EntityTemplate<LanguageType>
    {
        protected override LanguageType GetEntity(ModelBuilder builder)
        {
            LanguageType type = GetLanguageType();
            return type;
        }

        protected abstract LanguageType GetLanguageType();
    }
}
