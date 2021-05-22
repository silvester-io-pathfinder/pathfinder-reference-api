using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Languages.Instances
{
    public class Amurran : Template
    {
        public static readonly Guid ID = Guid.Parse("b968b2e8-1dc2-4c33-b108-5c58c36d85ed");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Uncommon.ID,
                Name = "Amurrun"
            };
        }
    }
}
