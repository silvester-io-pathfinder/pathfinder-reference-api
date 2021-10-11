using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheTyrant : Template
    {
        public static readonly Guid ID = Guid.Parse("b0f47762-2732-4c6f-a942-2eb0a7d2e7f4");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Tyrant",
                Description = "This card represents a ruler who harms those he rules.",
                AlignmentId = Alignments.Instances.LawfulEvil.ID,
                HarrowCategoryId = HarrowCategories.Instances.Crowns.ID
            };
        }
    }
}
