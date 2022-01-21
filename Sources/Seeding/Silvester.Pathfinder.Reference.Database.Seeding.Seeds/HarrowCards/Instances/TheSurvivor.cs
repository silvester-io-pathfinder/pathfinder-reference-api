using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheSurvivor : Template
    {
        public static readonly Guid ID = Guid.Parse("b46c628d-7f17-46b9-9073-4056bd8ff52d");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Survivor",
                Description = "This card represents a creature that has managed to survive a terrible ordeal, when everyone thought him lost.",
                AlignmentId = Alignments.Instances.NeutralGood.ID,
                HarrowCategoryId = HarrowCategories.Instances.Shields.ID
            };
        }
    }
}
