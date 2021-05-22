using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Languages.Instances
{
    public class Draconic : Template
    {
        public static readonly Guid ID = Guid.Parse("4bf191b9-77f7-47d0-89d7-e22555aaee7f");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Common.ID,
                Name = "Draconic"
            };
        }
    }
}
