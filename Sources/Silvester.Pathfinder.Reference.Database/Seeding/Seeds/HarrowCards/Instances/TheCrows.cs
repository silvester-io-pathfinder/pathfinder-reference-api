using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheCrows : Template
    {
        public static readonly Guid ID = Guid.Parse("7c80a2a7-de98-4530-b3c4-45c33119dd8f");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Crows",
                Description = "This card represents murder, theft, and the violent loss of that which is loved.",
                AlignmentId = Alignments.Instances.NeutralEvil.ID,
                HarrowCategoryId = HarrowCategories.Instances.Keys.ID
            };
        }
    }
}
