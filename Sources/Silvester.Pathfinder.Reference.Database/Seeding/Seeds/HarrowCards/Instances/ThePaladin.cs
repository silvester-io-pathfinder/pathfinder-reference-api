using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class ThePaladin : Template
    {
        public static readonly Guid ID = Guid.Parse("3ee23fa1-b445-45bb-a4c3-ea64b878c195");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Paladin",
                Description = "This card represents standing resolutely against trouble, without backing down.",
                AlignmentId = Alignments.Instances.LawfulGood.ID,
                HarrowCategoryId = HarrowCategories.Instances.Hammers.ID
            };
        }
    }
}
