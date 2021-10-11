using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheMountainMen : Template
    {
        public static readonly Guid ID = Guid.Parse("4932b769-ab64-4c04-b0ee-e424301b5f7d");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Mountain Men",
                Description = "This giant on this card represents an encounter with a physical power outside of the subject's control.",
                AlignmentId = Alignments.Instances.ChaoticNeutral.ID,
                HarrowCategoryId = HarrowCategories.Instances.Shields.ID
            };
        }
    }
}
