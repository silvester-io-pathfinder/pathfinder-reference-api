using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class StrangeGravity : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("16f0ab88-bf51-4946-9af6-13f14ba313dd");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Strange Gravity",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a7d07492-6d7c-41cd-a12f-0acb8c8922fd"), Type = TextBlockType.Text, Text = "On planes with this trait, all bodies of mass, regardless of size, are centers of gravity with roughly the same amount of force." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d6e5fef7-d39b-48cd-970e-6d55a8f6e696"),
                SourceId = GamemasteryGuide.ID,
                Page = 254
            };
        }
    }
}
