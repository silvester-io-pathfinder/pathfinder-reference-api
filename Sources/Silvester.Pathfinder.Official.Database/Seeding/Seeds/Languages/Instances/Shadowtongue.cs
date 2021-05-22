using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Languages.Instances
{
    public class Shadowtongue : Template
    {
        public static readonly Guid ID = Guid.Parse("1b30c0fb-885d-4b6f-a03c-2dd4c1639aae");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Uncommon.ID,
                Name = "Shadowtongue"
            };
        }
    }
}
