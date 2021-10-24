using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheTwin : Template
    {
        public static readonly Guid ID = Guid.Parse("b985490e-7a0a-41aa-8e15-fc7b89454fb0");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Twin",
                Description = "The doppelganger represents duality of purpose or identity, or indecision and fence-sitting for the subject or the entire spread.",
                AlignmentId = Alignments.Instances.TrueNeutral.ID,
                HarrowCategoryId = HarrowCategories.Instances.Crowns.ID
            };
        }
    }
}
