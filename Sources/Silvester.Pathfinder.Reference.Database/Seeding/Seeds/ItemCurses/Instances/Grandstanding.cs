using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemCurses.Instances
{
    public class Grandstanding : Template
    {
        public static readonly Guid ID = Guid.Parse("578a1f3e-8039-4342-a2b1-bcfa67035d7a");

		public override ItemCurse GetItemCurse()
        {
            return new ItemCurse
            {
                Id = ID,
                Name = "Grandstanding",
                Usage = "curses a weapon",
                Level = 11
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bbc4deb5-bd7e-4dce-aa0d-90d32db6da92"), Type = TextBlockType.Text, Text = "Weapons with the grandstanding curse inspire overconfidence in their wielders, demanding style over pragmatism. Whenever you reduce a foe to 0 Hit Points, you lose all remaining actions on your turn, as you are compelled to flourish, gloat, pose, or otherwise waste your time in response." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("17a087ee-8738-4035-b4c5-12fe78ff84a7"),
                SourceId = GamemasteryGuide.ID,
                Page = 93
            };
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Cursed.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Enchantment.ID;
        }
    }
}
