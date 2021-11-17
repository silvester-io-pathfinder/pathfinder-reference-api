using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Languages
{
    public abstract class Template : EntityTemplate<Language>
    {
        protected override Language GetEntity(ISeedBuilder builder)
        {
            Language language = GetLanguage();
            return language;
        }

        protected abstract Language GetLanguage();
    }
}
