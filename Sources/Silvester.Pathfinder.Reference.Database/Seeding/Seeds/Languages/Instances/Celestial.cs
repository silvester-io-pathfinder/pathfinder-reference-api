using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Languages.Instances
{
    public class Celestial : Template
    {
        public static readonly Guid ID = Guid.Parse("a2a126c5-0922-4e2c-929d-98cc10603aab");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Uncommon.ID,
                Name = "Celestial"
            };
        }
    }
}
