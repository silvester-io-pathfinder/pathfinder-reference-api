using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheAvalanche : Template
    {
        public static readonly Guid ID = Guid.Parse("4e319674-967a-4446-bb61-f92eb7a40526");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Avalanche",
                Description = "This card represents disaster: an unthinking panic and destruction that overruns all.",
                AlignmentId = Alignments.Instances.LawfulEvil.ID,
                HarrowCategoryId = HarrowCategories.Instances.Keys.ID
            };
        }
    }
}
