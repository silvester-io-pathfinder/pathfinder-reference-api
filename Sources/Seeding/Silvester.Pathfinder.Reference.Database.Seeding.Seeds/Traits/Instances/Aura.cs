using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Aura : Template
    {
        public static readonly Guid ID = Guid.Parse("fb4c9d91-e6e8-424f-b4c4-29d8b3b77464");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Aura",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("010c1c91-a2e8-4bec-afa0-dc15e2e222b2"), Type = TextBlockType.Text, Text = "An aura is an emanation that continually ebbs out from you, affecting creatures within a certain radius. Aura can also refer to the magical signature of an item or a creature with a strong alignment." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dcc4bd49-5208-4e5c-a505-780b94315010"),
                SourceId = CoreRulebook.ID,
                Page = 75
            };
        }
    }
}