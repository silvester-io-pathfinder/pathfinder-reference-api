using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Languages.Instances
{
    public class Shisk : Template
    {
        public static readonly Guid ID = Guid.Parse("c81dd9d1-ad11-4ed0-8099-4756c96f3aad");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Common.ID,
                Name = "Shisk"
            };
        }
    }
}
