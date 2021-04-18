﻿using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class BreathControlFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("a3395df1-fc95-4989-833c-c0d7465ecd1c"),
                Name = "Breath Control",
                Level = 1
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e6d543e3-8f19-45b3-ade2-59d9525160eb"), Type = Utilities.Text.TextBlockType.Text, Text = "You have incredible breath control, which grants you advantages when air is hazardous or sparse. You can hold your breath for 25 times as long as usual before suffocating. You gain a +1 circumstance bonus to saving throws against inhaled threats, such as inhaled poisons, and if you roll a success on such a saving throw, you get a critical success instead." };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
        }
    }
}
