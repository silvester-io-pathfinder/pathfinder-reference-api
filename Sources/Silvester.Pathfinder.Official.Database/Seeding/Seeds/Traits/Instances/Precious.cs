using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Precious : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("241dfc1f-e304-4fa0-a086-e87f5b621bdb");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Precious",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f0ccfe81-4b98-45dc-acdd-117be526a946"), Type = TextBlockType.Text, Text = "Valuable materials with special properties have the precious trait. They can be substituted for base materials when you Craft items." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9557ae8e-3804-4431-b9d0-73adcdb5b0e9"),
                SourceId = CoreRulebook.ID,
                Page = 635
            };
        }
    }
}
