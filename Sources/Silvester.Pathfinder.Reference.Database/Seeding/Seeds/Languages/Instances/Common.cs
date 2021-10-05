using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Languages.Instances
{
    public class Common : Template
    {
        public static readonly Guid ID = Guid.Parse("9200b27c-d210-4b47-bd77-43cfc86440d4");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Common.ID,
                Name = "Common"
            };
        }
    }
}
