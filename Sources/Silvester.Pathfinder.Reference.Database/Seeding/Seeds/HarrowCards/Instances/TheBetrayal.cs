using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheBetrayal : Template
    {
        public static readonly Guid ID = Guid.Parse("50ccb7a8-13ad-43e8-bb35-1a87f06e63b7");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Betrayal",
                Description = "This card represents selfishness and envy.",
                AlignmentId = Alignments.Instances.NeutralEvil.ID,
                HarrowCategoryId = HarrowCategories.Instances.Crowns.ID
            };
        }
    }
}
