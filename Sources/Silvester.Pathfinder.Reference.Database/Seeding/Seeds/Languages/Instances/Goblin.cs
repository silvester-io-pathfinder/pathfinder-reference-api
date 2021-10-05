using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Languages.Instances
{
    public class Goblin : Template
    {
        public static readonly Guid ID = Guid.Parse("bbbe92c4-628e-4b49-a1fb-9845a0071980");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Common.ID,
                Name = "Goblin"
            };
        }
    }
}
