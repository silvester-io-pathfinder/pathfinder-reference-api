using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemCurses.Instances
{
    public class Arsonous : Template
    {
        public static readonly Guid ID = Guid.Parse("77b3847f-7cb6-4d8e-9eb0-8c348b0b755c");

		public override ItemCurse GetItemCurse()
        {
            return new ItemCurse
            {
                Id = ID,
                Name = "Arsonous",
                Usage = "curses a ring, staff, or wand",
                Level = 7
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("44a99ce1-b79a-4110-963d-fabbe80784d1"), Type = TextBlockType.Text, Text = "An arsonous curse creates flaws in the mystic pathways that channel magic through an item, allowing excess power to escape as sparks. Whenever you activate the magic item, a random ally within 30 feet takes 1d10 persistent fire damage. If no ally is in range, you take the damage instead. At the GM’s discretion, this curse might ignite an unattended object or the surrounding environment instead." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("949a09f9-a465-43f7-854a-b24e4c9462f4"),
                SourceId = GamemasteryGuide.ID,
                Page = 92
            };
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Cursed.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Fire.ID;
            yield return Traits.Instances.Evocation.ID;
        }
    }
}
