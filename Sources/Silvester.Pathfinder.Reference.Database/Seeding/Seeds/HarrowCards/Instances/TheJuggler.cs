using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheJuggler : Template
    {
        public static readonly Guid ID = Guid.Parse("7c83c53c-0ad3-4791-88ec-26f71722273e");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Juggler",
                Description = "This card represents destiny, deities, and those who play with the fates of others.",
                AlignmentId = Alignments.Instances.ChaoticGood.ID,
                HarrowCategoryId = HarrowCategories.Instances.Keys.ID
            };
        }
    }
}
