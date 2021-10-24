using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheRabbitPrince : Template
    {
        public static readonly Guid ID = Guid.Parse("afd86a76-91ac-4efe-9204-fdeed2434235");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Rabbit Prince",
                Description = "This card represents the quiky vicissitudes of melee combat. The Rabbit Prince is the personification of the capriciousness of battle, and his broken sword indicates that defeat may come to anyone. The card sometimes represents younger members of royal or noble houses.",
                AlignmentId = Alignments.Instances.ChaoticNeutral.ID,
                HarrowCategoryId = HarrowCategories.Instances.Keys.ID
            };
        }
    }
}
