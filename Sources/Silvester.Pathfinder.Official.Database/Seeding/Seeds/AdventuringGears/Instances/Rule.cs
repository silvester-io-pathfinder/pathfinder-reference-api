using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class Rule : Template
    {
        public static readonly Guid ID = Guid.Parse("be4541a0-3103-4718-b398-cd2a4dfc9295");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Rule",
                Hands = "1",
                Price = 50,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("36a20efa-fdb6-4611-a536-4dd539b2bd3f"), Type = TextBlockType.Text, Text = "A ruler is a straight-edged object used for measuring small distances accurately and drawing straight lines." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a30ac35f-e8b5-4d90-ae44-baa07af61855"),
                SourceId = PathfinderSocietyGuide.ID,
                Page = 34
            };
        }
    }
}
