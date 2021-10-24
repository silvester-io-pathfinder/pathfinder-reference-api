using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Languages.Instances
{
    public class Terran : Template
    {
        public static readonly Guid ID = Guid.Parse("096204ff-a686-4f09-95f9-9353401cb37a");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Uncommon.ID,
                Name = "Terran"
            };
        }
    }
}
