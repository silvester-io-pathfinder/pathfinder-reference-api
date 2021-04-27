using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Undead : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("ede91540-2a4d-4e56-acec-da634658309a");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Undead",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("efafcb77-2553-4069-9c23-e91835f1aca7"), Type = TextBlockType.Text, Text = "Once living, these creatures were infused after death with negative energy and soul-corrupting evil magic. When reduced to 0 Hit Points, an undead creature is destroyed. Undead creatures are damaged by positive energy, are healed by negative energy, and don’t benefit from healing effects." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("059d878f-6ef4-43cd-b1af-9c29c7219cd0"),
                SourceId = CoreRulebook.ID,
                Page = 637
            };
        }
    }
}
