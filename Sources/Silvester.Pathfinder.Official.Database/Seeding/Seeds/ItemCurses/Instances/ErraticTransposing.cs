using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemCurses.Instances
{
    public class ErraticTransposing : AbstractItemCurseTemplate
    {
        public override ItemCurse GetItemCurse(ItemCurseSeeder seeder)
        {
            return new ItemCurse
            {
                Id = Guid.Parse("369897ab-d7b6-4077-ad4e-69580e0b95fa"),
                Name = "Erratic Transposing",
                Usage = "curses a weapon",
                Level = 11
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks(ItemCurseSeeder seeder)
        {
            yield return new TextBlock { Id = Guid.Parse("58b2dbcb-9d2c-4c0d-9b9f-894c7365accb"), Type = TextBlockType.Text, Text = "This curse bursts with uncontrolled teleportation magic when activated, unreliably transporting creatures across the battlefield. On a critical hit with the affected weapon, you and an ally within 60 feet (chosen randomly) teleport to switch places with one another. If either of the affected creatures is unable to entirely fit within its new space, the creature is placed in the nearest available squares instead." };
        }

        public override SourcePage GetSourcePage(ItemCurseSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("7ec67c91-f70d-4a7d-b79f-8d06e4b1d88f"),
                SourceId = seeder.GetSourceByName("Gamemastery Guide").Id,
                Page = 93
            };
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Rare";
            yield return "Cursed";
            yield return "Magical";
            yield return "Conjuration";
        }
    }
}
