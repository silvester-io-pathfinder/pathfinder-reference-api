using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheCricket : Template
    {
        public static readonly Guid ID = Guid.Parse("3c9564b4-240b-4035-ac82-bf7440324793");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Cricket",
                Description = "This card represents the grig, quick travel, and the reward at the end of a journey.",
                AlignmentId = Alignments.Instances.NeutralGood.ID,
                HarrowCategoryId = HarrowCategories.Instances.Keys.ID
            };
        }
    }
}
