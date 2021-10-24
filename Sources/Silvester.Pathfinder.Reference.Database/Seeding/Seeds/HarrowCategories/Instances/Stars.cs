using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCategories.Instances
{
    public class Stars : Template
    {
        public static readonly Guid ID = Guid.Parse("00a8a0f0-ccf2-44d6-857f-cf6d9265b5c4");

        protected override HarrowCategory GetHarrow()
        {
            return new HarrowCategory
            {
                Id = ID,
                Name = "Stars",
                Effects = "Will saving throws.",
                AffectedStatId = Stats.Instances.Wisdom.ID,
                Description = "In the Harrow deck, Wisdom is one of a creature's six basic abilities, represented by a star. Wisdom represents a creature's willpower, common sense, awareness, intuition, and perception, and may indicate facility with divine magic. In a harrowing, it more broadly symbolizes ancient history, morality, and the gods."
            }; 
        }
    }
}
