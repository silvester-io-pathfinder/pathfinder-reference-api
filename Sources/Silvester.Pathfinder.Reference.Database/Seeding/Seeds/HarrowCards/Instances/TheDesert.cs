using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheDesert : Template
    {
        public static readonly Guid ID = Guid.Parse("614b1ca6-978c-4055-bc7d-d64fbc43f9df");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Desert",
                Description = "This card represents an environment too difficult for anyone to survive without help. The sphinx may represent a source of salvation from plague.",
                AlignmentId = Alignments.Instances.ChaoticGood.ID,
                HarrowCategoryId = HarrowCategories.Instances.Shields.ID
            };
        }
    }
}
