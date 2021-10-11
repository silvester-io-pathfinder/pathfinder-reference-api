using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheForeignTrader : Template
    {
        public static readonly Guid ID = Guid.Parse("cebe7481-3983-42b1-adf5-a934b753e5b9");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Foreign Trader",
                Description = "This card represents spies, merchants, and those who truck in information.",
                AlignmentId = Alignments.Instances.TrueNeutral.ID,
                HarrowCategoryId = HarrowCategories.Instances.Books.ID
            };
        }
    }
}
