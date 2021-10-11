using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheSickness : Template
    {
        public static readonly Guid ID = Guid.Parse("ff70d46e-0203-43bd-81ee-e6b491fd713b");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Sickness",
                Description = "This card represents corruption, famine, plague, pestilence, and disease.",
                AlignmentId = Alignments.Instances.NeutralEvil.ID,
                HarrowCategoryId = HarrowCategories.Instances.Shields.ID
            };
        }
    }
}
