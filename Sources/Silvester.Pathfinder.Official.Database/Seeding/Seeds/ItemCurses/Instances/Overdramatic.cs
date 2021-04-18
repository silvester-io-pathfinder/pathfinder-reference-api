using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemCurses.Instances
{
    public class Overdramatic : AbstractItemCurseTemplate
    {
        public override ItemCurse GetItemCurse(ItemCurseSeeder seeder)
        {
            return new ItemCurse
            {
                Id = Guid.Parse("53cbef47-8c65-4869-9494-4bc53daa4475"),
                Name = "Overdramatic",
                Usage = "curses a weapon",
                Level = 5
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks(ItemCurseSeeder seeder)
        {
            yield return new TextBlock { Id = Guid.Parse("e50b741a-3b1e-49f6-8a19-d6d6d18b9678"), Type = TextBlockType.Text, Text = "The weapon flashes excessive light with each attack. On a critical hit with the weapon, you are blinded until the end of your turn and take the effects of a faerie fire spell until the start of your next turn." };
        }

        public override SourcePage GetSourcePage(ItemCurseSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("6f2cfabe-86c5-461a-9aea-dd9eb7f66d65"),
                SourceId = seeder.GetSourceByName("Gamemastery Guide").Id,
                Page = 93
            };
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Rare";
            yield return "Cursed";
            yield return "Magical";
            yield return "Evocation";
        }
    }
}
