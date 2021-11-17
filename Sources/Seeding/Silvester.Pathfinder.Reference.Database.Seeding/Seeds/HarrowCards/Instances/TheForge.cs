using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheForge : Template
    {
        public static readonly Guid ID = Guid.Parse("0f536380-05b8-4101-87e7-7fd3b316ecc6");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Forge",
                Description = "This card represents strength through diversity, or strength from many sources united against a single trial.",
                AlignmentId = Alignments.Instances.LawfulNeutral.ID,
                HarrowCategoryId = HarrowCategories.Instances.Hammers.ID
            };
        }
    }
}
