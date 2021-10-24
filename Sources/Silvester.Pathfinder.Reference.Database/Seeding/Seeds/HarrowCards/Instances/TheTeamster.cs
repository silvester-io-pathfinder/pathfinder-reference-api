using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheTeamster : Template
    {
        public static readonly Guid ID = Guid.Parse("6c0f1f6a-3f80-4846-b38e-5bf60fdf3725");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Teamster",
                Description = "This card represents a external force that drives the subject on.",
                AlignmentId = Alignments.Instances.TrueNeutral.ID,
                HarrowCategoryId = HarrowCategories.Instances.Shields.ID
            };
        }
    }
}
