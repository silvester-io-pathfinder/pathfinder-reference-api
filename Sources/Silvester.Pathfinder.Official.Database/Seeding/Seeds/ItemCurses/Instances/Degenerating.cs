using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemCurses.Instances
{
    public class Degenerating : AbstractItemCurseTemplate
    {
        public override ItemCurse GetItemCurse(ItemCurseSeeder seeder)
        {
            return new ItemCurse
            {
                Id = Guid.Parse("ec2335e5-bcde-44c4-b9a6-c352b1c02073"),
                Name = "Degenerating",
                Usage = "curses a weapon",
                Level = 5
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks(ItemCurseSeeder seeder)
        {
            yield return new TextBlock { Id = Guid.Parse("76a4cd2a-762d-4674-b7b4-bc23f240b295"), Type = TextBlockType.Text, Text = "Failure makes the weapon crumble. Whenever you critically fail an attack roll with the weapon, the degenerating curse deals 1d10 acid damage to the weapon, ignoring its Hardness and resistances." };
        }

        public override SourcePage GetSourcePage(ItemCurseSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("d83fc2c9-c14f-4684-9189-3256ae62fb2e"),
                SourceId = seeder.GetSourceByName("Gamemastery Guide").Id,
                Page = 93
            };
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Rare";
            yield return "Cursed";
            yield return "Magical";
            yield return "Necromancy";
        }
    }
}
