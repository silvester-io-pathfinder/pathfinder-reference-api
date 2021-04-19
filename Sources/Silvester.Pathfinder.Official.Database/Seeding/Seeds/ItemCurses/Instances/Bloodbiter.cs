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
    public class Bloodbiter : AbstractItemCurseTemplate
    {
        public override ItemCurse GetItemCurse(ItemCurseSeeder seeder)
        {
            return new ItemCurse
            {
                Id = Guid.Parse("b2f407cf-7fe0-42fa-ac0e-2524621e8a3b"),
                Name = "Bloodbiter",
                Usage = "curses a piercing or slashing weapon",
                Level = 6
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks(ItemCurseSeeder seeder)
        {
            yield return new TextBlock { Id = Guid.Parse("f5ae85ad-0ab5-4862-a27f-9d6813003af0"), Type = TextBlockType.Text, Text = "A bloodbiter weapon is awakened by violence and fueled by blood. When you make a successful attack with the weapon, it inflicts a wound that deals 1d6 persistent bleed damage (in addition to its normal damage), but it also deals 1d6 persistent bleed damage to you. The curse remains dormant until the weapon hits a creature, at which point black thorns protrude from the weapon and dig into your body; the weapon fuses to you and you can’t use the hand that holds the weapon for any other purpose. If the weapon is two-handed, it attaches itself to only a single hand (GM’s choice)." };
        }

        public override SourcePage GetSourcePage(ItemCurseSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("513b8a6b-de2e-4112-8be8-89d52ac74be9"),
                SourceId = GamemasteryGuide.ID,
                Page = 92
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
