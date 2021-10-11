using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheDance : Template
    {
        public static readonly Guid ID = Guid.Parse("db81882d-ec11-4b6f-b63b-f95218590332");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Dance",
                Description = "This card represents a complicated framework that requires the cooperation of all to avoid collapse.",
                AlignmentId = Alignments.Instances.LawfulGood.ID,
                HarrowCategoryId = HarrowCategories.Instances.Keys.ID
            };
        }
    }
}
