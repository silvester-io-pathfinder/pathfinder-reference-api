using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Languages.Instances
{
    public class Jotun : Template
    {
        public static readonly Guid ID = Guid.Parse("956c9a02-b3db-41d2-83f3-3c27fa43e510");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Common.ID,
                Name = "Jotun"
            };
        }
    }
}
