using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheLiar : Template
    {
        public static readonly Guid ID = Guid.Parse("d65301cf-35f4-41cb-bdb8-66c8a490327c");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Liar",
                Description = "This card represents destructive, treacherous love. The lamia signals obsession, star-crossed lovers, or unrequited desire.",
                AlignmentId = Alignments.Instances.ChaoticEvil.ID,
                HarrowCategoryId = HarrowCategories.Instances.Crowns.ID
            };
        }
    }
}
