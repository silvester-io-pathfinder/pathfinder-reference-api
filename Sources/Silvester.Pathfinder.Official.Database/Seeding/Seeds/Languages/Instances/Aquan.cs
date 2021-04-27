using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Languages.Instances
{
    public class Aquan : AbstractLanguageTemplate
    {
        public static readonly Guid ID = Guid.Parse("fe8f7dca-685b-4595-8d0c-ee72e0239d58");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Uncommon.ID,
                Name = "Aquan"
            };
        }
    }
}
