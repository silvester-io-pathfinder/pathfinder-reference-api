using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemCurses.Instances
{
    public class Dependent : Template
    {
        public static readonly Guid ID = Guid.Parse("6e4d1c6a-b506-4a2f-8ab0-03a1ebea1696");

		public override ItemCurse GetItemCurse()
        {
            return new ItemCurse
            {
                Id = ID,
                Name = "Dependent",
                Usage = "curses gear used for skills or a weapon",
                Level = 9
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d2124045-cd88-43c5-985d-f62755d34242"), Type = TextBlockType.Text, Text = "The dependent curse makes an item function properly only under certain circumstances. Whenever you use the item to perform a skill check or use the weapon in combat, your degree of success is one worse than the result you rolled unless those specific conditions are met. The most common types of dependent curses are nocturnal or diurnal—functioning normally only at night or only during the day, respectively—but more restrictive curses do exist, such as a curse that restricts the item’s use to underground or a curse that allows the item to function effectively only during autumn." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9d6def2c-671e-41c5-9422-3fd2f06fd5aa"),
                SourceId = GamemasteryGuide.ID,
                Page = 93
            };
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Cursed.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Transmutation.ID;
        }
    }
}
