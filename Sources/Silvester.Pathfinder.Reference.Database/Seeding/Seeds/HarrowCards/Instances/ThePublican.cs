using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class ThePublican : Template
    {
        public static readonly Guid ID = Guid.Parse("205384c3-688c-4e25-9117-8222eb82cb54");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Publican",
                Description = "This card represents fellowship and refuge. The cyclops is a seemingly inconsequential figure who nonetheless has relevant insight.",
                AlignmentId = Alignments.Instances.ChaoticGood.ID,
                HarrowCategoryId = HarrowCategories.Instances.Stars.ID
            };
        }
    }
}
