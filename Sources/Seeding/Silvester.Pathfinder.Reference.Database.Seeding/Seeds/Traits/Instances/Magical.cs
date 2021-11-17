using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Magical : Template
    {
        public static readonly Guid ID = Guid.Parse("4ab621bd-943d-46f8-bc1b-b087444eec87");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Magical",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8a0ef240-af91-4da8-9ac2-5bfdc6f549b5"), Type = TextBlockType.Text, Text = "Something with the magical trait is imbued with magical energies not tied to a specific tradition of magic. A magical item radiates a magic aura infused with its dominant school of magic." };
            yield return new TextBlock { Id = Guid.Parse("ec01b62e-8a08-4f2a-b2d9-9cd8dcc5133f"), Type = TextBlockType.Text, Text = "Some items or effects are closely tied to a particular tradition of magic. In these cases, the item has the arcane, divine, occult, or primal trait instead of the magical trait. Any of these traits indicate that the item is magical." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dbe48e3d-022a-41b4-9d42-45de23b3a1c7"),
                SourceId = CoreRulebook.ID,
                Page = 633
            };
        }
    }
}
