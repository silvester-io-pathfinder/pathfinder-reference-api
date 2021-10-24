using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemCurses.Instances
{
    public class Raucous : Template
    {
        public static readonly Guid ID = Guid.Parse("dade2400-c464-4171-a0f4-5367292b51a3");

		public override ItemCurse GetItemCurse()
        {
            return new ItemCurse
            {
                Id = ID,
                Name = "Raucous",
                Usage = "curses gear or a weapon",
                Level = 3
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8aeba1cd-97c8-4c5d-92f9-6a48781efa95"), Type = TextBlockType.Text, Text = "A weapon with the backbiting curse warps space in response to catastrophic mishaps. Whenever you critically fail at a Strike with this weapon, the weapon curls around (or its projectile swerves through the air) to strike you in the back as though you hit yourself, automatically dealing maximum damage to you." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9283dbff-bc55-44ee-bf3c-8b2ac4f873cd"),
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
