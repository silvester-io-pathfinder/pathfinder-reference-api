using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Consumable : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("a5a1682b-6393-40a8-b426-51167dc74233");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Consumable",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1416dbd5-d311-45a9-8ad2-6ce3eec76e21"), Type = TextBlockType.Text, Text = "An item with this trait can be used only once. Unless stated otherwise, it's destroyed after activation. Consumable items include alchemical items and magical consumables such as scrolls and talismans. When a character creates consumable items, they can make them in batches of four." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6f7e6037-dfe9-4407-b9f2-0a5478ef849b"),
                SourceId = CoreRulebook.ID,
                Page = 630
            };
        }
    }
}
