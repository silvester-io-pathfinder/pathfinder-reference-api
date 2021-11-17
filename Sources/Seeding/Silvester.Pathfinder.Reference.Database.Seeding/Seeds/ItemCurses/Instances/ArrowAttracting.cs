using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemCurses.Instances
{
    public class ArrowAttracting : Template
    {
        public static readonly Guid ID = Guid.Parse("247f52a1-f309-4e64-9020-6cec69d2a048");

		public override ItemCurse GetItemCurse()
        {
            return new ItemCurse
            {
                Id = ID,
                Name = "Arrow Attracting",
                Usage = "curses armor or shield",
                Level = 8
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5fe7530b-0555-4b3e-88a0-6bd6f28e08cc"), Type = TextBlockType.Text, Text = "An item affected by an arrow attracting curse protects you normally, but it draws ranged attacks like a magnet. Whenever a creature within 120 feet misses with a ranged attack, it must immediately reroll the attack against your AC, affecting you depending on the result of the new attack roll. The arrow attraction curse activates only if you could have been a legitimate target. Creatures that intentionally attempt to miss a ranged attack do not activate an arrow attraction curse. Once the curse has activated for the first time, the item fuses to you." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("33411eb6-96e3-4ef9-a3fc-3371cf073dc9"),
                SourceId = GamemasteryGuide.ID,
                Page = 92
            };
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Cursed.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Abjuration.ID;
        }
    }
}
