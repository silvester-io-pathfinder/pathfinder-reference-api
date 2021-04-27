using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Fatal : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("bd45aa85-b7e8-4425-ad9b-546b1f073e65");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Fatal",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("010bf1d9-99c0-4223-a0e6-d0e05a2eba5d"), Type = TextBlockType.Text, Text = "The fatal trait includes a die size. On a critical hit, the weapon’s damage die increases to that die size instead of the normal die size, and the weapon adds one additional damage die of the listed size." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c64f28ec-8317-4178-bfce-907bd0d9a29a"),
                SourceId = CoreRulebook.ID,
                Page = 282
            };
        }
    }
}
