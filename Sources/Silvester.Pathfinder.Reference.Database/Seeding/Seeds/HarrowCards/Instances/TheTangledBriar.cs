using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheTangledBriar : Template
    {
        public static readonly Guid ID = Guid.Parse("476f687c-5f8d-45d5-9dd7-2363dfe4a20a");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Tangled Briar",
                Description = "This card represents a historical thing or creature that will have some influence on the question.",
                AlignmentId = Alignments.Instances.LawfulEvil.ID,
                HarrowCategoryId = HarrowCategories.Instances.Shields.ID
            };
        }
    }
}
