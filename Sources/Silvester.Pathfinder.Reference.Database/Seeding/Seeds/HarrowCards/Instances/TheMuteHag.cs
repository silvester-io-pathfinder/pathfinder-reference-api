using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheMuteHag : Template
    {
        public static readonly Guid ID = Guid.Parse("c2ee630a-7d1f-4802-9463-0673b7073d12");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Mute Hag",
                Description = "This card represents the insightful hag, a purveyor of blood pacts, treacherous secrets, and discord.",
                AlignmentId = Alignments.Instances.NeutralEvil.ID,
                HarrowCategoryId = HarrowCategories.Instances.Stars.ID
            };
        }
    }
}
