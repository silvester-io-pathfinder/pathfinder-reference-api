using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheIdiot : Template
    {
        public static readonly Guid ID = Guid.Parse("8e2f01aa-095b-4c02-b6f6-497111db457a");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Idiot",
                Description = "This card represents folly, greed, blackmail, bribery, or hubris.",
                AlignmentId = Alignments.Instances.NeutralEvil.ID,
                HarrowCategoryId = HarrowCategories.Instances.Books.ID
            };
        }
    }
}
