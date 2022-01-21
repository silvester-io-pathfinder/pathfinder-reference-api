using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheMidwife : Template
    {
        public static readonly Guid ID = Guid.Parse("5667f73d-3617-42a1-80b4-8a9c45e4f335");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Midwife",
                Description = "This card represents the enabler or conduit of new creation, information, or arrivals.",
                AlignmentId = Alignments.Instances.NeutralGood.ID,
                HarrowCategoryId = HarrowCategories.Instances.Stars.ID
            };
        }
    }
}
