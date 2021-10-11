using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheInquisitor : Template
    {
        public static readonly Guid ID = Guid.Parse("b1edeb8e-60fe-4ed3-9598-76c80e927b08");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Inquisitor",
                Description = "This card represents an immutable object that cannot be deceived or influenced.",
                AlignmentId = Alignments.Instances.LawfulNeutral.ID,
                HarrowCategoryId = HarrowCategories.Instances.Books.ID
            };
        }
    }
}
