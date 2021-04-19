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
    public class Ravenous : AbstractItemCurseTemplate
    {
        public override ItemCurse GetItemCurse(ItemCurseSeeder seeder)
        {
            return new ItemCurse
            {
                Id = Guid.Parse("c1881624-ab21-4295-bdf7-81617c04b051"),
                Name = "Ravenous",
                Usage = "curses a ring, staff, or wand",
                Level = 1
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks(ItemCurseSeeder seeder)
        {
            yield return new TextBlock { Id = Guid.Parse("72bbc67f-8a60-42ed-bf86-820ee0f80fae"), Type = TextBlockType.Text, Text = "A ravenous curse draws power from the wielder’s body. Whenever you activate the item, you become incredibly hungry and immediately begin to starve. You require 10 times as much food as normal for the next day." };
        }

        public override SourcePage GetSourcePage(ItemCurseSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("1d412b5e-b818-4d4c-aab7-e91471eb46eb"),
                SourceId = GamemasteryGuide.ID,
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
