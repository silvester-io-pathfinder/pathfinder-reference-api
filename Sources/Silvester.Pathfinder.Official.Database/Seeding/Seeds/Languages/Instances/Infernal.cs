using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Languages.Instances
{
    public class Infernal : AbstractLanguageTemplate
    {
        public static readonly Guid ID = Guid.Parse("efaeb70a-9ba1-4026-a1cb-51272efba480");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Uncommon.ID,
                Name = "Infernal"
            };
        }
    }
}
