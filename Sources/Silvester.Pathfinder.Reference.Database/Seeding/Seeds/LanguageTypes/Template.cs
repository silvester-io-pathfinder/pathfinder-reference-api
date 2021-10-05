using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.LanguageTypes
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
