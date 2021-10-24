using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Languages.Instances
{
    public class Gnoll : Template
    {
        public static readonly Guid ID = Guid.Parse("6de09882-17f3-43f2-9c8d-81d78f75d988");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Uncommon.ID,
                Name = "Gnoll"
            };
        }
    }
}
