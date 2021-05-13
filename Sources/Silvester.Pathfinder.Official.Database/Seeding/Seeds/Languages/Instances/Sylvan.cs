using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Languages.Instances
{
    public class Sylvan : Template
    {
        public static readonly Guid ID = Guid.Parse("be3b5aa6-e2eb-49b8-8273-a3eb516dcfc7");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Common.ID,
                Name = "Sylvan"
            };
        }
    }
}
