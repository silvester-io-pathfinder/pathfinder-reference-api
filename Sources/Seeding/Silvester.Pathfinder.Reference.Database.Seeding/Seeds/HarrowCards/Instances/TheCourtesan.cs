using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheCourtesan : Template
    {
        public static readonly Guid ID = Guid.Parse("90b136e3-9b41-4485-ba30-270ec51bab8c");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Courtesan",
                Description = "This card represents political intrigue and the superficiality of social niceties.",
                AlignmentId = Alignments.Instances.ChaoticNeutral.ID,
                HarrowCategoryId = HarrowCategories.Instances.Crowns.ID
            };
        }
    }
}
