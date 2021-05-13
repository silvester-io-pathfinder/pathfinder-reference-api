using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Languages.Instances
{
    public class Aklo : Template
    {
        public static readonly Guid ID = Guid.Parse("6085b848-9283-494b-bf9d-999917f5d9d9");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Uncommon.ID,
                Name = "Aklo"
            };
        }
    }
}
