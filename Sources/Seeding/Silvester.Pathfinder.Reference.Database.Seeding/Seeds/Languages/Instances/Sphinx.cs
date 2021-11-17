using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Languages.Instances
{
    public class Sphinx : Template
    {
        public static readonly Guid ID = Guid.Parse("2062e8dd-6e0b-4b03-83f9-2d1d5c0a7ba5");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Common.ID,
                Name = "Sphinx"
            };
        }
    }
}
