using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Goblin : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("70348794-b594-4be3-967c-f6ccd30738a8");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Goblin",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1e3bdc89-a872-4bce-b93f-64c866217f02"), Type = TextBlockType.Text, Text = "A creature with this trait can be one of several kinds of creature, including goblins, hobgoblins, and bugbears. Goblins tend to have darkvision. An ability with this trait can be used or chosen only by goblins. A weapon with this trait is created and used by goblins." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4704b24d-4705-46ec-b36e-a64be14c3a5f"),
                SourceId = CoreRulebook.ID,
                Page = 632
            };
        }
    }
}
