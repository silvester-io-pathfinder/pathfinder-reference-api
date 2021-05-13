using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class AlchemistsLab : Template
    {
        public static readonly Guid ID = Guid.Parse("8f6a633a-5b05-499b-bcf7-459f0a4710f1");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Alchemist's Lab",
                Hands = "2",
                ItemLevel = "0",
                Price = 500,
                BulkId = Bulks.Instances.SixBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<AdventuringGearVariant> GetVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("b789ea83-1f28-4146-86e2-fb5193696b72"),
                NameAddendum = "Expanded",
                DescriptionAddendum = "An expanded alchemist's lab gives a +1 item bonus to Crafting checks to create alchemical items.",
                Price = 5500,
                ItemLevel = 3,
                Hands = 2,
                BulkId = Bulks.Instances.SixBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a6c0e44b-e2c7-46d4-92ce-cbaccf522278"), Type = TextBlockType.Text, Text = "You need an alchemist's lab to Craft alchemical items during downtime." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2686c706-c844-404b-9420-d87e5fa2caac"),
                SourceId = CoreRulebook.ID,
                Page = 287
            };
        }
    }
}
