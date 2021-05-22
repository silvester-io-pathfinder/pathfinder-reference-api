using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Languages.Instances
{
    public class Halfling : Template
    {
        public static readonly Guid ID = Guid.Parse("f05615ab-eba0-476d-8afd-1f628b90240b");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Common.ID,
                Name = "Halfling"
            };
        }
    }
}
