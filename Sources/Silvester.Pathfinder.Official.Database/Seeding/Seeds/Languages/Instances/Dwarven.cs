using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Languages.Instances
{
    public class Dwarven : Template
    {
        public static readonly Guid ID = Guid.Parse("59a55746-938a-459e-8ff3-ce201de0a452");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Common.ID,
                Name = "Dwarven"
            };
        }
    }
}
