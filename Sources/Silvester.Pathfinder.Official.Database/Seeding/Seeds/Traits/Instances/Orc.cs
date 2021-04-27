using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Orc : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("9e1a7583-3f46-410f-9c29-1de74ad87f1c");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Orc",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c2535727-868d-4f22-a05f-3fbe750dffe2"), Type = TextBlockType.Text, Text = "A creature with this trait is a member of the orc ancestry. These green-skinned people tend to have darkvision. An ability with this trait can be used or selected only by orcs. An item with this trait is created and used by orcs." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("19ff5ad1-b064-4f3e-8855-c594f657e9fe"),
                SourceId = CoreRulebook.ID,
                Page = 634
            };
        }
    }
}
