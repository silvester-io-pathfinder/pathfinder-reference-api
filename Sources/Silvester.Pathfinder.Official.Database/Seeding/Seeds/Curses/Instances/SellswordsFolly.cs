using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.SavingThrowStats.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Curse = Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances.Curse;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Curses.Instances
{
    public class SellswordsFolly : AbstractCurseTemplate
    {
        public static readonly Guid ID = Guid.Parse("cb8e0c92-9867-4cf1-b70c-dbff7df35ef4");

		public override Models.Curse GetCurse()
        {
            return new Models.Curse
            {
                Id = ID,
                Level = 9,
                Name = "Sellsword's Folly",
                DifficultyCheck = 26,
                SavingThrowStatId = Will.ID,
                Effect = "The chaos of combat overwhelms you. Each time you roll initiative for a combat encounter, you must attempt a new saving throw against the curse; on a failure, you become confused for 1 round. This is an incapacitation effect."
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3b1acf9a-6f81-4321-8c2f-9ac27a9cc810"), Type = TextBlockType.Text, Text = "Even the most experienced combat veteran becomes as reckless as a rookie when suffering from sellsword’s folly." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("67ac171e-a625-4874-a370-3bd0230809e6"),
                SourceId = GamemasteryGuide.ID,
                Page = 117
            };
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Curse.ID;
            yield return Magical.ID;
            yield return Emotion.ID;
            yield return Enchantment.ID;
            yield return Mental.ID;
        }
    }
}
