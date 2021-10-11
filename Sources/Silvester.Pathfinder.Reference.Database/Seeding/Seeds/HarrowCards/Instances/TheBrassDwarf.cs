using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheBrassDwarf : Template
    {
        public static readonly Guid ID = Guid.Parse("d546f60e-f4b7-4f0f-a98f-24bb8dee7dd8");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Brass Dwarf",
                Description = "This card shows an azer. It represents a creature invulnerable to a current threat.",
                AlignmentId = Alignments.Instances.LawfulNeutral.ID,
                HarrowCategoryId = HarrowCategories.Instances.Shields.ID
            };
        }
    }
}
