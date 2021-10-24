using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheWingedSerpent : Template
    {
        public static readonly Guid ID = Guid.Parse("428808cc-4b87-4d54-a81b-a778f78df8a6");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Winged Serpent",
                Description = "This card represents the couatl, the bridge of understanding between the towers of knowledge and judgement.",
                AlignmentId = Alignments.Instances.LawfulGood.ID,
                HarrowCategoryId = HarrowCategories.Instances.Stars.ID
            };
        }
    }
}
