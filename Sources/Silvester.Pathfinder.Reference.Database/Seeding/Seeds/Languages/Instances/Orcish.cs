using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Languages.Instances
{
    public class Orcish : Template
    {
        public static readonly Guid ID = Guid.Parse("ba4a2924-27ab-49a1-b700-310b1cfb0c22");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Common.ID,
                Name = "Orcish"
            };
        }
    }
}
