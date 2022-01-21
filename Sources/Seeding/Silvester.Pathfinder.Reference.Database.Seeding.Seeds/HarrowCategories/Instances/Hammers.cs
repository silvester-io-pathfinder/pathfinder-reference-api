using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCategories.Instances
{
    public class Hammers : Template
    {
        public static readonly Guid ID = Guid.Parse("816c551e-121f-47dd-8174-31f651f577dc");

        protected override HarrowCategory GetHarrow()
        {
            return new HarrowCategory
            {
                Id = ID,
                Name = "Hammers",
                Effects = "Attack rolls (both ranged and melee)",
                AffectedStatId = Stats.Instances.Strength.ID,
                Description = "In the Harrow deck, Strength is one of a creature's six basic abilities, represented as a hammer. Strength represents a creature's muscular and physical power, and its ability to fight in melee. In a harrowing, it more broadly symbolizes war, battle, and honor."
            }; 
        }
    }
}
