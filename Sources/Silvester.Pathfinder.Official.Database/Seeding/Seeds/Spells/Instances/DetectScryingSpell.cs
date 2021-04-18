﻿using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DetectScryingSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Divination";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("2ef1bfc9-3ca3-45b8-804a-ba9d948224de"),
                Name = "Detect Scrying",
                Level = 4,
                Area = "30-foot emanation",
                Duration = "1 hour."
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cfb7389d-5dcb-4251-9f63-8285f2e85105"), Type = Utilities.Text.TextBlockType.Text, Text = "By tapping into trace divinatory auras, you detect the presence of scrying effects in the area. If detect scrying is higher level than a scrying effect, you gain a glimpse of the scrying creature and learn its approximate distance and direction." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("9e4831ac-5cfe-4a20-9583-6d18d37fa4d2"), 
                Level = 6,
                Details =
                {
                    new TextBlock { Id = Guid.Parse("bf8ce5df-06bb-49f9-9c3f-7b0af705fff0"), Type = Utilities.Text.TextBlockType.Text, Text = "The duration is until the next time you make your daily preparations." }
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
            yield return "Occult";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Uncommon";
            yield return "Detection";
            yield return "Divination";
        }
    }
}
