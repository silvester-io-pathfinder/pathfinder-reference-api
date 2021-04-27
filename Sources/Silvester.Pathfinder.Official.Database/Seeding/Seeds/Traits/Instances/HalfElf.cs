using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class HalfElf : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("380d5cc3-0d40-4636-b23e-dc090a807cfb");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Half-Elf",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d97e3df5-91b7-4e41-a0d1-3432fd4829f5"), Type = TextBlockType.Text, Text = "A creature with this trait is part human and part elf. An ability with this trait can be used or selected only by half-elves." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("57b32e9d-bfc7-4714-b441-c77efa8a27a9"),
                SourceId = CoreRulebook.ID,
                Page = 632
            };
        }
    }
}
