using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheUnicorn : Template
    {
        public static readonly Guid ID = Guid.Parse("6ad42797-746b-4e7a-85ff-b90e3512b853");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Unicorn",
                Description = "This card represents one who generously offers up that which is sought.",
                AlignmentId = Alignments.Instances.ChaoticGood.ID,
                HarrowCategoryId = HarrowCategories.Instances.Crowns.ID
            };
        }
    }
}
