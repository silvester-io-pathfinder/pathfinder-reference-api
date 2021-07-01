using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class Snowshoes : Template
    {
        public static readonly Guid ID = Guid.Parse("361e8665-4225-4915-a3fa-f75b9a619b6b");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Snowshoes",
                Hands = "0",
                Price = 1000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("71593858-9d82-46ff-8893-c1d0f62a6c19"), Type = TextBlockType.Text, Text = "These specialized pieces of footwear are designed to distribute the wearer's weight over a larger area to prevent them from sinking while walking on snow. They are typically made with a wood frame and rawhide lacings that are tied over the wearer's other footwear. While wearing snowshoes, you ignore the effects of non-magical difficult terrain caused by snow (reducing greater difficult terrain from snow to ordinary difficult terrain). You take a –10-foot item penalty to your Speed if wearing snowshoes while walking on any surface other than snow." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("88efa217-6a95-4582-942b-f1af8d98aea8"),
                SourceId = PathfinderSocietyGuide.ID,
                Page = 115
            };
        }
    }
}
