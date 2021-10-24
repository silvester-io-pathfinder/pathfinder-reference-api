using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheLocksmith : Template
    {
        public static readonly Guid ID = Guid.Parse("08c8c95e-6f7e-4c6e-8031-88219cc7d8ab");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Locksmith",
                Description = "This card represents the keys the subject needs to unlock his fate. The card grants the tools needed to unlock some new place, puzzle, or hoard.",
                AlignmentId = Alignments.Instances.LawfulNeutral.ID,
                HarrowCategoryId = HarrowCategories.Instances.Keys.ID
            };
        }
    }
}
