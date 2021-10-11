using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheKeep : Template
    {
        public static readonly Guid ID = Guid.Parse("488e7dd9-0415-4ac4-884e-191adeaadaa9");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Keep",
                Description = "This card represents quiet, unshakeable strength that withstands any hardship.",
                AlignmentId = Alignments.Instances.NeutralGood.ID,
                HarrowCategoryId = HarrowCategories.Instances.Hammers.ID
            };
        }
    }
}
