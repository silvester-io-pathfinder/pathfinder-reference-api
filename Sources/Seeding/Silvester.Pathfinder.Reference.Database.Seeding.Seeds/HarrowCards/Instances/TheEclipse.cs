using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheEclipse : Template
    {
        public static readonly Guid ID = Guid.Parse("8fcdd7cb-474b-4cc0-84f7-da5d9bb0687d");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Eclipse",
                Description = "This card represents loss of faith and purpose, and the subject's doubt about his abilities or prospects.",
                AlignmentId = Alignments.Instances.LawfulEvil.ID,
                HarrowCategoryId = HarrowCategories.Instances.Stars.ID
            };
        }
    }
}
