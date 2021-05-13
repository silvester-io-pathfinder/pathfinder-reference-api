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
    public class ReviledOfNature : Template
    {
        public static readonly Guid ID = Guid.Parse("7df1d5bf-f713-4416-a429-aaf001da62c9");

		public override Models.Curse GetCurse()
        {
            return new Models.Curse
            {
                Id = ID,
                Level = 18,
                Name = "Reviled of Nature",
                DifficultyCheck = 38,
                SavingThrowStatId = Will.ID,
                Effect = "Creatures of the natural world abhor you. Whenever an animal becomes aware of you, it must attempt a Will save against the curse. On a failure, it attacks you and fights to the death."
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("32de8d51-a3fb-42a8-b2cf-210ea45f2233"), Type = TextBlockType.Text, Text = "This curse makes the hunter into the hunted, drawing the ire of animals wherever you go." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b34cbb91-fc87-44a3-aeff-bb908f12c71c"),
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
