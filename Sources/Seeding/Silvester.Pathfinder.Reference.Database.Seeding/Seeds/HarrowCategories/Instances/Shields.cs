using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCategories.Instances
{
    public class Shields : Template
    {
        public static readonly Guid ID = Guid.Parse("1e014cf6-edef-4152-8282-976c63183e85");

        protected override HarrowCategory GetHarrow()
        {
            return new HarrowCategory
            {
                Id = ID,
                Name = "Shields",
                Effects = "Fortitude saving throws.",
                AffectedStatId = Stats.Instances.Constitution.ID,
                Description = "In the Harrow deck,Constitution is one of a creature's six basic abilities, represented by a shield. Constitution represents a creature's health, stamina, and increased ability to survive injuries or disease. In a harrowing, it more broadly symbolizes health, the home, and pain."
            }; 
        }
    }
}
