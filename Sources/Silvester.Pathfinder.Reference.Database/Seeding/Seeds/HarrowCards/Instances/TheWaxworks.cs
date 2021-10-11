using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheWaxworks : Template
    {
        public static readonly Guid ID = Guid.Parse("c9d3018b-1054-459b-bf8c-a9ec9a739c3c");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Waxworks",
                Description = "This card represents a place of torture, imprisonment, helplessness, and paralysis.",
                AlignmentId = Alignments.Instances.ChaoticEvil.ID,
                HarrowCategoryId = HarrowCategories.Instances.Shields.ID
            };
        }
    }
}
