using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheRakshasa : Template
    {
        public static readonly Guid ID = Guid.Parse("9a55e82c-b94b-43cf-acfe-dd9844b9ea06");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Rakshasa",
                Description = "The rakshasa represents domination, mental control, and slavery.",
                AlignmentId = Alignments.Instances.LawfulEvil.ID,
                HarrowCategoryId = HarrowCategories.Instances.Books.ID
            };
        }
    }
}
