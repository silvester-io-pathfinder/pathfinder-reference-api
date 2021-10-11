using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCategories.Instances
{
    public class Keys : Template
    {
        public static readonly Guid ID = Guid.Parse("80628807-c237-4722-b853-99ccd44f18fe");

        protected override HarrowCategory GetHarrow()
        {
            return new HarrowCategory
            {
                Id = ID,
                Name = "Keys",
                Effects = "Reflex saving throws.",
                AffectedStatId = Stats.Instances.Dexterity.ID,
                Description = "In the Harrow deck, Dexterity is one of a creature's six basic abilities, represented as a key. Dexterity represents a creature's agility, reflexes, balance, and skill with ranged weapons. In a harrowing, it more broadly symbolizes trouble, children, and entertainment."
            }; 
        }
    }
}
