using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Languages
{
    public abstract class Template : EntityTemplate<Language>
    {
        protected override Language GetEntity(ModelBuilder builder)
        {
            Language language = GetLanguage();
            return language;
        }

        protected abstract Language GetLanguage();
    }
}
