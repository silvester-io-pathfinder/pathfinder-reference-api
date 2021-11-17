using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Languages.Instances
{
    public class Aquan : Template
    {
        public static readonly Guid ID = Guid.Parse("a79840c1-15f2-41a3-ab60-3e8a40cf1865");

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
