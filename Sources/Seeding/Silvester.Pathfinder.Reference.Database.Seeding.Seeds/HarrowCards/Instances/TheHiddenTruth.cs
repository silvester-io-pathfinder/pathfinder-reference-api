using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheHiddenTruth : Template
    {
        public static readonly Guid ID = Guid.Parse("e865cb89-6694-4c83-a30e-a187975fe3d0");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Hidden Truth",
                Description = "This card represents the discovery of the greater truth within.",
                AlignmentId = Alignments.Instances.LawfulGood.ID,
                HarrowCategoryId = HarrowCategories.Instances.Books.ID
            };
        }
    }
}
