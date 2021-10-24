using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemCurses.Instances
{
    public class Degenerating : Template
    {
        public static readonly Guid ID = Guid.Parse("ec2335e5-bcde-44c4-b9a6-c352b1c02073");

		public override ItemCurse GetItemCurse()
        {
            return new ItemCurse
            {
                Id = ID,
                Name = "Degenerating",
                Usage = "curses a weapon",
                Level = 5
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("76a4cd2a-762d-4674-b7b4-bc23f240b295"), Type = TextBlockType.Text, Text = "Failure makes the weapon crumble. Whenever you critically fail an attack roll with the weapon, the degenerating curse deals 1d10 acid damage to the weapon, ignoring its Hardness and resistances." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d83fc2c9-c14f-4684-9189-3256ae62fb2e"),
                SourceId = GamemasteryGuide.ID,
                Page = 93
            };
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Cursed.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Necromancy.ID;
        }
    }
}
