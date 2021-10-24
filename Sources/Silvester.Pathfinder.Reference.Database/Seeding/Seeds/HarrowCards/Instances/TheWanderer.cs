using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheWanderer : Template
    {
        public static readonly Guid ID = Guid.Parse("d107afa1-7d4b-473e-849f-5d190b839c24");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Wanderer",
                Description = "This card represents a centaur collector who appreciates things others discard as junk.",
                AlignmentId = Alignments.Instances.NeutralGood.ID,
                HarrowCategoryId = HarrowCategories.Instances.Books.ID
            };
        }
    }
}
