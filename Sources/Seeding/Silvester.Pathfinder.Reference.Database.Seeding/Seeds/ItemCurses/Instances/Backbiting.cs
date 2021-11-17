using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemCurses.Instances
{
    public class Backbiting : Template
    {
        public static readonly Guid ID = Guid.Parse("11d686ec-2c9a-4c0f-b7da-d8318c38bc64");

		public override ItemCurse GetItemCurse()
        {
            return new ItemCurse
            {
                Id = ID,
                Name = "Backbiting",
                Usage = "curses a weapon",
                Level = 4
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0a648746-7fea-4db6-a7e9-14adb15467ec"), Type = TextBlockType.Text, Text = "A weapon with the backbiting curse warps space in response to catastrophic mishaps. Whenever you critically fail at a Strike with this weapon, the weapon curls around (or its projectile swerves through the air) to strike you in the back as though you hit yourself, automatically dealing maximum damage to you." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("179f1b27-8e26-4a51-a396-a01a1b2d6f6a"),
                SourceId = GamemasteryGuide.ID,
                Page = 92
            };
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Cursed.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Evocation.ID;
        }
    }
}
