using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheFiend : Template
    {
        public static readonly Guid ID = Guid.Parse("9157096b-d6f1-4b68-a427-31b38adda43f");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Fiend",
                Description = "This card is a devil that devours the masses of the innocent, and can represent the deaths of many in a disaster.",
                AlignmentId = Alignments.Instances.LawfulEvil.ID,
                HarrowCategoryId = HarrowCategories.Instances.Hammers.ID
            };
        }
    }
}
