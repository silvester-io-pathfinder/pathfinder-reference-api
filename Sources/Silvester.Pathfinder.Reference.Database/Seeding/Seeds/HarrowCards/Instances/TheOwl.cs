using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheOwl : Template
    {
        public static readonly Guid ID = Guid.Parse("b4de2ad4-6b32-4c09-9b94-d0e8d74709a6");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Owl",
                Description = "This card represents the harsh wisdom of the natural order. The owl holds a needle that can bind life together or pick it apart.",
                AlignmentId = Alignments.Instances.TrueNeutral.ID,
                HarrowCategoryId = HarrowCategories.Instances.Stars.ID
            };
        }
    }
}
