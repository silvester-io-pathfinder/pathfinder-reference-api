using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Duergar : Template
    {
        public static readonly Guid ID = Guid.Parse("842c7c08-d536-476a-a8e5-b2093a5e79b7");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Duergar",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7fbc45b3-a680-4728-a991-660a31ea46b1"), Type = TextBlockType.Text, Text = "Subterranean kin of the dwarves, duergar typically have darkvision and immunity to poison. They are not easily fooled by illusions." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fc05311b-66ce-4437-8f11-0702374902a9"),
                SourceId = CoreRulebook.ID,
                Page = 631
            };
        }
    }
}
