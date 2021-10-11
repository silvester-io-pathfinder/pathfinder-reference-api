using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheDemonsLantern : Template
    {
        public static readonly Guid ID = Guid.Parse("6518c131-368b-4e74-b021-439d54fecb16");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Demon's Lantern",
                Description = "This card represents an impossible situation of traps, mind tricks, and sleight of hand.",
                AlignmentId = Alignments.Instances.ChaoticEvil.ID,
                HarrowCategoryId = HarrowCategories.Instances.Keys.ID
            };
        }
    }
}
