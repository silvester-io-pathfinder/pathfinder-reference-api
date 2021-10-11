using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheBear : Template
    {
        public static readonly Guid ID = Guid.Parse("ff6780f7-ba7c-4b74-b873-3c79425f433d");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Bear",
                Description = "This card represents pure strength that cannot be truly tamed or trained.",
                AlignmentId = Alignments.Instances.TrueNeutral.ID,
                HarrowCategoryId = HarrowCategories.Instances.Hammers.ID
            };
        }
    }
}
