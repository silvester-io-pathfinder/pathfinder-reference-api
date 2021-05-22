using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Languages.Instances
{
    public class Necril : Template
    {
        public static readonly Guid ID = Guid.Parse("3b5d9eb0-04e7-48a0-a611-32475680a811");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Uncommon.ID,
                Name = "Necril"
            };
        }
    }
}
