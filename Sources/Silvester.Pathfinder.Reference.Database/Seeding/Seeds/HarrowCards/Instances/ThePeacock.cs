using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class ThePeacock : Template
    {
        public static readonly Guid ID = Guid.Parse("b5ce9aeb-2b9c-43fc-b0da-23415cd8b31f");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Peacock",
                Description = "This card represents a great beauty that can only be preserved if petrified and frozen in time for eternity, as by a cockatrice's glare.",
                AlignmentId = Alignments.Instances.TrueNeutral.ID,
                HarrowCategoryId = HarrowCategories.Instances.Keys.ID
            };
        }
    }
}
