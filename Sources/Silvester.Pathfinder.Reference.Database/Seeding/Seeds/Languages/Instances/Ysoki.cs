using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Languages.Instances
{
    public class Ysoki : Template
    {
        public static readonly Guid ID = Guid.Parse("6a5332d4-f0b7-4e9b-8016-ccb5d03e9d0f");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Uncommon.ID,
                Name = "Ysoki"
            };
        }
    }
}
