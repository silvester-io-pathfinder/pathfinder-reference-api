using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SavingThrowStats.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Curse = Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances.Curse;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Curses.Instances
{
    public class TheftOfThought : Template
    {
        public static readonly Guid ID = Guid.Parse("a93f6011-ae01-4927-9e74-485dd52be9e1");

		public override Models.Curse GetCurse()
        {
            return new Models.Curse
            {
                Id = ID,
                Level = 3,
                Name = "Theft of Thought",
                DifficultyCheck = 18,
                SavingThrowStatId = Will.ID,
                Effect = "You begin to lose details from your memories, as well as a portion of your procedural memory. After being cursed, the first time you attempt a check using a skill in which you are trained or better, your proficiency rank in the skill used decreases by one rank for as long as you are cursed."
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("366d3a0d-d1a3-4d52-8d12-67188cafd7b6"), Type = TextBlockType.Text, Text = "This curse protects a single book and activates against any creature who Steals it." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1cd2d6c8-d88d-4d3f-a057-bf808f867a96"),
                SourceId = GamemasteryGuide.ID,
                Page = 116
            };
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Curse.ID;
            yield return Magical.ID;
            yield return Enchantment.ID;
            yield return Mental.ID;
        }
    }
}
