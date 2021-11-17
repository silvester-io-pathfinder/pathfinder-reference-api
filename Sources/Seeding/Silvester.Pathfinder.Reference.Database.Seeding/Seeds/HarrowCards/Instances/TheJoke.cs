using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheJoke : Template
    {
        public static readonly Guid ID = Guid.Parse("5b36f8d9-71fb-4b7d-b663-6696bd8ddcd2");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Joke",
                Description = "This card represents a monster that can only be defeated through trickery, or the value of humor in circumventing difficult people.",
                AlignmentId = Alignments.Instances.ChaoticGood.ID,
                HarrowCategoryId = HarrowCategories.Instances.Books.ID
            };
        }
    }
}
