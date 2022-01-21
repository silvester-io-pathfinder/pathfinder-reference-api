using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheEmptyThrone : Template
    {
        public static readonly Guid ID = Guid.Parse("6a0fffb0-6e34-467a-bee3-b8c2cc4b2209");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Empty Throne",
                Description = "This card represents those who are gone, or a ghost of the past that has taught important lessons.",
                AlignmentId = Alignments.Instances.LawfulGood.ID,
                HarrowCategoryId = HarrowCategories.Instances.Crowns.ID
            };
        }
    }
}
