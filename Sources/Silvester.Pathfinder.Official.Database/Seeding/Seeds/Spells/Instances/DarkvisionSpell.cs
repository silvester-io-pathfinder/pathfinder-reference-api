using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DarkvisionSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Divination";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("66172098-6cdb-4587-89bb-24fe1a8faf7c"),
                Name = "Darkvision",
                Level = 2,
                Duration = "1 hour."
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c9a23b3f-b2ed-40b3-87cc-431369d6297a"), Type = Utilities.Text.TextBlockType.Text, Text = "You grant yourself supernatural sight in areas of darkness. You gain darkvision." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("b2fd64f9-51d7-42fb-b78d-fd29bf47f508"), 
                Level = 3, 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("12971af1-dc37-4275-8caa-f1b40df0c206"), Type = Utilities.Text.TextBlockType.Text, Text = "The spell’s range is touch and it targets 1 willing creature." }
                }
            };

            yield return new SpellHeightening
            { 
                Id = Guid.Parse("3d32cc67-f66b-4b7d-a267-ff050108114c"), 
                Level = 5,
                Details =
                {
                    new TextBlock { Id = Guid.Parse("58b96894-4f49-442f-977c-482e7dd65f1c"), Type = Utilities.Text.TextBlockType.Text, Text = "The spell’s range is touch and it targets 1 willing creature.The duration is until the next time you make your daily preparations." }
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
            yield return "Divine";
            yield return "Occult";
            yield return "Primal";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Divination";
        }
    }
}
