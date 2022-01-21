using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCategories.Instances
{
    public class Books : Template
    {
        public static readonly Guid ID = Guid.Parse("5b5a4fa5-ddfd-4cde-85fa-958c09180358");

        protected override HarrowCategory GetHarrow()
        {
            return new HarrowCategory
            {
                Id = ID,
                Name = "Books",
                Effects = "Skill checks.",
                AffectedStatId = Stats.Instances.Intelligence.ID,
                Description = "In the Harrow deck, Intelligence is one of a creature's six basic abilities, represented by a book. Intelligence represents a creature's ability to learn and reason, and may indicate facility with languages or arcane magic. In a harrowing, it more broadly symbolizes money, school, and literature."
            }; 
        }
    }
}
