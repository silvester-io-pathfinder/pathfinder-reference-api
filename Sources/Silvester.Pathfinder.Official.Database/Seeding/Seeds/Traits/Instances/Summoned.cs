using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Summoned : Template
    {
        public static readonly Guid ID = Guid.Parse("7fe537ca-5287-4bc8-8cca-5273dd45504b");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Summoned",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("08158f2c-8878-4645-addb-a87955e50cc0"), Type = TextBlockType.Text, Text = "A creature called by a conjuration spell or effect gains the summoned trait. A summoned creature can't summon other creatures, create things of value, or cast spells that require a cost. It has the minion trait. If it tries to cast a spell of equal or higher level than the spell that summoned it, it overpowers the summoning magic, causing the summoned creature's spell to fail and the summon spell to end. Otherwise, the summoned creature uses the standard abilities for a creature of its kind. It generally attacks your enemies to the best of its abilities. If you can communicate with it, you can attempt to command it, but the GM determines the degree to which it follows your commands." };
            yield return new TextBlock { Id = Guid.Parse("0b6210b6-3424-4e02-9c32-f6d9f9d2f5ab"), Type = TextBlockType.Text, Text = "Immediately when you finish Casting the Spell, the summoned creature uses its 2 actions for that turn. A summoned creature can't control any spawn or other creatures generated from it, and such creatures return to their unaltered state (usually a corpse in the case of spawn) once the summoned creature is gone. If it's unclear what this state would be, the GM decides. Summoned creatures can be banished by various spells and effects. They are automatically banished if reduced to 0 Hit Points or if the spell that called them ends." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("69584037-f778-4b9e-890e-9e1e41ff5361"),
                SourceId = CoreRulebook.ID,
                Page = 637
            };
        }
    }
}
