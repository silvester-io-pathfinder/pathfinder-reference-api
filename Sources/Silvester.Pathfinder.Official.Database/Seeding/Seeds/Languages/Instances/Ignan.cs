using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Languages.Instances
{
    public class Ignan : Template
    {
        public static readonly Guid ID = Guid.Parse("f4c44558-f01d-4b2e-a98d-5ed75f5a5c87");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Uncommon.ID,
                Name = "Ignan"
            };
        }
    }
}
