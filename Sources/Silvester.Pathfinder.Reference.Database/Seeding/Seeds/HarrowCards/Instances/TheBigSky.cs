using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheBigSky : Template
    {
        public static readonly Guid ID = Guid.Parse("2def1a6f-1e6a-4b47-87fa-2047181d0e22");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Big Sky",
                Description = "This card represents momentous change, as when all the slaves of a nation are emancipated.",
                AlignmentId = Alignments.Instances.ChaoticGood.ID,
                HarrowCategoryId = HarrowCategories.Instances.Hammers.ID
            };
        }
    }
}
