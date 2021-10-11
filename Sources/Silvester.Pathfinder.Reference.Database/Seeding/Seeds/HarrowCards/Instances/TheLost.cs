using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheLost : Template
    {
        public static readonly Guid ID = Guid.Parse("008d0f4c-ac98-4741-83a4-1068d74c8593");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Lost",
                Description = "The bodak represents the permanently insane, lost among lunatics and psychopaths in insane asylums. It is a card of emptiness.",
                AlignmentId = Alignments.Instances.ChaoticEvil.ID,
                HarrowCategoryId = HarrowCategories.Instances.Stars.ID
            };
        }
    }
}
