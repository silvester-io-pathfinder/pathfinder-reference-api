using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Languages.Instances
{
    public class Abyssal : Template
    {
        public static readonly Guid ID = Guid.Parse("7fba9655-f430-4ef1-acd7-996f398f4e60");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Uncommon.ID,
                Name = "Abyssal"
            };
        }
    }
}
