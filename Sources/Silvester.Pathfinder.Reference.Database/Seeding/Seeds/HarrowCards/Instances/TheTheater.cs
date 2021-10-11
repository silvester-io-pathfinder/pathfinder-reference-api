using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheTheater : Template
    {
        public static readonly Guid ID = Guid.Parse("d8393bbc-c0f2-4575-a690-641f25e3420a");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Theater",
                Description = "This card represents prophecy, with a true prophet acting a part as the puppet of the gods.",
                AlignmentId = Alignments.Instances.NeutralGood.ID,
                HarrowCategoryId = HarrowCategories.Instances.Crowns.ID
            };
        }
    }
}
