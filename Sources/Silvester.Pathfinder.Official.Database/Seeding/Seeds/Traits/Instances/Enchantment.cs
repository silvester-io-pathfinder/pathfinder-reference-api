using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Enchantment : Template
    {
        public static readonly Guid ID = Guid.Parse("e96a77cb-4271-4f08-bf95-de459742767a");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Enchantment",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5c7e8690-62bd-4282-86ed-190431b70d77"), Type = TextBlockType.Text, Text = "Effects and magic items with this trait are associated with the enchantment school of magic, typically involving mind control, emotion alteration, and other mental effects." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("42581294-0c08-4618-9bfc-43f18462821c"),
                SourceId = CoreRulebook.ID,
                Page = 631
            };
        }
    }
}
