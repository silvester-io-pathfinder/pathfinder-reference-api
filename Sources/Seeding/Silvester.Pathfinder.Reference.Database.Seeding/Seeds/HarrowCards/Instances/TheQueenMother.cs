using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheQueenMother : Template
    {
        public static readonly Guid ID = Guid.Parse("e5154479-7d0c-442c-8765-f0bb8b53a2ac");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Queen Mother",
                Description = "This formian is the personification of knowledge, who is fond of the powerless, the underclass, and those who will show her obeisance.",
                AlignmentId = Alignments.Instances.LawfulNeutral.ID,
                HarrowCategoryId = HarrowCategories.Instances.Stars.ID
            };
        }
    }
}
