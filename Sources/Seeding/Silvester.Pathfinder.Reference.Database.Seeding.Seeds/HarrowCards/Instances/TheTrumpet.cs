using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards.Instances
{
    public class TheTrumpet : Template
    {
        public static readonly Guid ID = Guid.Parse("e8b742db-a3e5-495b-aac3-87a9db5c26bf");

        protected override HarrowCard GetHarrowCard()
        {
            return new HarrowCard
            {
                Id = ID, 
                Name = "The Trumpet",
                Description = "This card represents an archon who dives aggressively and righteously into danger.",
                AlignmentId = Alignments.Instances.LawfulGood.ID,
                HarrowCategoryId = HarrowCategories.Instances.Shields.ID
            };
        }
    }
}
