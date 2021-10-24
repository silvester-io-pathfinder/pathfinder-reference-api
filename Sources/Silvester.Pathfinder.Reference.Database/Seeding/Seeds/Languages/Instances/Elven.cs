using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Languages.Instances
{
    public class Elven : Template
    {
        public static readonly Guid ID = Guid.Parse("4fc0e030-aa67-4913-b738-16b82ac46354");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Common.ID,
                Name = "Elven"
            };
        }
    }
}
