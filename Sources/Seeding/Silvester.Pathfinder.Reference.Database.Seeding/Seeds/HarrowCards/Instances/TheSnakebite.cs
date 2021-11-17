using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheSnakebite : Template
    {
        public static readonly Guid ID = Guid.Parse("be417556-4244-4572-b677-68bf63a6b72a");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Snakebite",
                Description = "This card represents poison, venom, assassination, and discord.",
                AlignmentId = Alignments.Instances.ChaoticEvil.ID,
                HarrowCategoryId = HarrowCategories.Instances.Books.ID
            };
        }
    }
}
