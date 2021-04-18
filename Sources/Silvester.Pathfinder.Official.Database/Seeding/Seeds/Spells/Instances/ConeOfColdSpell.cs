using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ConeOfColdSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Evocation";
        public override string SavingThrowStat => "Reflex";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("2a4b767b-27d0-4519-b1f7-c554837d0c73"),
                Name = "Cone of Cold",
                Level = 5,
                Area = "60-foot cone."
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("febabf42-20fa-4193-8215-b9c24c6fc140"), Type = Utilities.Text.TextBlockType.Text, Text = "Icy cold rushes forth from your hands. You deal 12d6 cold damage to creatures in the area." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("e6a136cc-0056-439b-b6a2-dd406c4b5752"), 
                Level = 1, 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("c3270595-28ea-4452-a365-8a9d0785edca"), Type = Utilities.Text.TextBlockType.Text, Text = "The damage increases by 2d6." }
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
            yield return "Arcane";
            yield return "Primal";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Cold";
            yield return "Evocation";
        }
    }
}
