using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DisruptingWeaponsSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Necromancy";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("9627d10b-e488-4299-9e1b-2c3a511ec007"),
                Name = "Disrupting Weapons",
                Level = 1,
                Range = 0,
                Targets = "Up to two weapons, each of which must be wielded by you or a willing ally, or else is unattended.",
                Duration = "1 minute"
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("906d1df1-2636-4767-b5e1-f828b458d2c3"), Type = Utilities.Text.TextBlockType.Text, Text = "You infuse weapons with positive energy. Attacks with these weapons deal an extra 1d4 positive damage to undead." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("25598434-fc72-4c97-b895-060cada42dda"), 
                Level = 3,
                Details =
                {
                    new TextBlock { Id = Guid.Parse("8bb751c4-64ba-4146-97fd-b2cac56abf29"), Type = Utilities.Text.TextBlockType.Text, Text = "The damage increases to 2d4 damage." }
                }
            };

            yield return new SpellHeightening
            { 
                Id = Guid.Parse("766b8628-93b0-4a8f-baf9-d7be6eb4e957"),
                Level = 5,
                Details =
                {
                    new TextBlock { Id = Guid.Parse("239f5167-8c42-4002-99cd-8447f93db2dd"), Type = Utilities.Text.TextBlockType.Text, Text = "Target up to three weapons, and the damage increases to 3d4 damage." }
                }
            };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Divine";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Necromancy";
            yield return "Positive";
        }
    }
}
