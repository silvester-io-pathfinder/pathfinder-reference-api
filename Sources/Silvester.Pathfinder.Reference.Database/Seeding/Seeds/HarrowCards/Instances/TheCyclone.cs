using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheCyclone : Template
    {
        public static readonly Guid ID = Guid.Parse("3df236db-06ab-4969-9f08-9ae54f5238d6");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Cyclone",
                Description = "This card represents an unstoppable, destructive force unleashed through the plots of intelligent creatures.",
                AlignmentId = Alignments.Instances.ChaoticEvil.ID,
                HarrowCategoryId = HarrowCategories.Instances.Hammers.ID
            };
        }
    }
}
