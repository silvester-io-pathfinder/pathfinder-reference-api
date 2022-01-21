using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheMarriage : Template
    {
        public static readonly Guid ID = Guid.Parse("36f70a46-e228-422c-ac16-2100194817bc");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Marriage",
                Description = "This card represents a union of peoples, ideas, or kingdoms that might be as productive or as ruinous as the bonding of a salamander and a water weird.",
                AlignmentId = Alignments.Instances.LawfulNeutral.ID,
                HarrowCategoryId = HarrowCategories.Instances.Crowns.ID
            };
        }
    }
}
