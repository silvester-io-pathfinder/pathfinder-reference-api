using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheUprising : Template
    {
        public static readonly Guid ID = Guid.Parse("ab49ddaf-f4de-451e-830b-182d7b04b1e7");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Uprising",
                Description = "This card represents overwhelming strength that catches the subject up in something much more powerful.",
                AlignmentId = Alignments.Instances.ChaoticNeutral.ID,
                HarrowCategoryId = HarrowCategories.Instances.Hammers.ID
            };
        }
    }
}
