using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Languages.Instances
{
    public class Auran : AbstractLanguageTemplate
    {
        public static readonly Guid ID = Guid.Parse("e3f3ba6c-0589-4c16-b625-093a1fa1edce");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Uncommon.ID,
                Name = "Auran"
            };
        }
    }
}
