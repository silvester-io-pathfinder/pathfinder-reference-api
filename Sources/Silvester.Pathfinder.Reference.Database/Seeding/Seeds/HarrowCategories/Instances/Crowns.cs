using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCategories.Instances
{
    public class Crowns : Template
    {
        public static readonly Guid ID = Guid.Parse("e846c193-0fba-4e66-bb57-9f6a581c19d1");

        protected override HarrowCategory GetHarrow()
        {
            return new HarrowCategory
            {
                Id = ID,
                Name = "Crowns",
                Effects = "Any d20 roll.",
                AffectedStatId = Stats.Instances.Charisma.ID,
                Description = "In the Harrow deck, Charisma is one of a creature's six basic abilities, represented by a crown. Charisma represents a creature's personality, personal magnetism, ability to lead, and appearance, and may indicate facility with magic cast spontaneously. In a harrowing, it more broadly symbolizes love, family, and politics."
            }; 
        }
    }
}
