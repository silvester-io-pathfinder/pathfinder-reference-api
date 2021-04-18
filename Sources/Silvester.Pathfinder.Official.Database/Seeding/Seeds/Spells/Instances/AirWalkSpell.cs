﻿using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class AirWalkSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Transmutation";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("5c0b6313-4951-4dc4-9289-0ec20210643d"),
                Name = "Air Walk",
                Duration = "5 minutes.",
                Targets = "1 creature.",
                Range = 0,
                Level = 4,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6c32648f-499d-4392-aed9-194555267d3c"), Type = Utilities.Text.TextBlockType.Text, Text = "The target can walk on air as if it were solid ground. It can ascend and descend in this way at a maximum of a 45 - degree angle." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Divine";
            yield return "Primal";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Air";
            yield return "Transmutation";
        }
    }
}
