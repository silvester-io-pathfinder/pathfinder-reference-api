using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheBeating : Template
    {
        public static readonly Guid ID = Guid.Parse("39ae425d-4004-4360-8339-1daa7ef4e8fc");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Beating",
                Description = "This card represents an assault from all quarters, or the mental dissolution of the self.",
                AlignmentId = Alignments.Instances.NeutralEvil.ID,
                HarrowCategoryId = HarrowCategories.Instances.Hammers.ID
            };
        }
    }
}
