using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheCarnival : Template
    {
        public static readonly Guid ID = Guid.Parse("57097501-7492-4ef5-87f0-c47eb9ba1348");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Carnival",
                Description = "This card represents illusions and false dreams.",
                AlignmentId = Alignments.Instances.ChaoticNeutral.ID,
                HarrowCategoryId = HarrowCategories.Instances.Stars.ID
            };
        }
    }
}
