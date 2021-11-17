using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Backstabber : Template
    {
        public static readonly Guid ID = Guid.Parse("58bbbff9-2391-4b10-9dd5-ef55e8dc41ef");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Backstabber",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("501bd431-5666-4ebe-a22b-ad3d4f54f673"), Type = TextBlockType.Text, Text = "When you hit a flat-footed creature, this weapon deals 1 precision damage in addition to its normal damage. The precision damage increases to 2 if the weapon is a +3 weapon." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bcfbe291-a702-4fe5-ad3e-a12b88fc41e1"),
                SourceId = CoreRulebook.ID,
                Page = 282
            };
        }
    }
}
