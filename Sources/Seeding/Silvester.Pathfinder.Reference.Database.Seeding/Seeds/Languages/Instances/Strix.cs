using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Languages.Instances
{
    public class Strix : Template
    {
        public static readonly Guid ID = Guid.Parse("f069a0c9-e0e8-4c70-9a6f-9fd9c97d1230");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Common.ID,
                Name = "Strix"
            };
        }
    }
}
