using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemCurses.Instances
{
    public class Staining : AbstractItemCurseTemplate
    {
        public override ItemCurse GetItemCurse(ItemCurseSeeder seeder)
        {
            return new ItemCurse
            {
                Id = Guid.Parse("8170f8c0-0cdb-4c14-8cb3-2e208ae58552"),
                Name = "Staining",
                Usage = "curses gear or a weapon",
                Level = 1
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks(ItemCurseSeeder seeder)
        {
            yield return new TextBlock { Id = Guid.Parse("f889ad21-5731-4546-bd72-71d323d5be54"), Type = TextBlockType.Text, Text = "This property is associated with a specific color, which is defined at the time of the curse’s creation. Whenever you use the affected equipment while taking a manipulate action with another object, the second object is permanently stained the associated color. For instance, if you used a set of yellow staining lockpicks to open a door, the lock would permanently become yellow. This color change does not otherwise unnaturally persist and can be changed via any normal mundane or magical means." };
        }

        public override SourcePage GetSourcePage(ItemCurseSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("8bda699e-5ba4-4e33-b363-dd9b65e785bf"),
                SourceId = GamemasteryGuide.ID,
                Page = 93
            };
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Rare";
            yield return "Cursed";
            yield return "Magical";
            yield return "Transmutation";
        }
    }
}
