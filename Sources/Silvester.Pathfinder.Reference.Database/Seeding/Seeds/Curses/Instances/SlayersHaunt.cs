using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SavingThrowStats.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Curse = Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances.Curse;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Curses.Instances
{
    public class SlayersHaunt : Template
    {
        public static readonly Guid ID = Guid.Parse("debd8716-f744-4e4c-9e3a-4b6cdbdfc581");

		public override Models.Curse GetCurse()
        {
            return new Models.Curse
            {
                Id = ID,
                Level = 4,
                Name = "Slayer's Haunt",
                DifficultyCheck = 19,
                SavingThrowStatId = Will.ID,
                Effect = "You see all creatures around you as those you have slain, still bearing their wounds. You can’t identify, Recall Knowledge about, or otherwise interact with these creatures in any way that involves seeing their true form without first succeeding at a Will save against the curse’s DC to see through the illusion. On a critical failure for such a Will save, you become frightened 1."
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("94a1353c-3d3a-4a3d-9bf5-8e1d0e7ee0a2"), Type = TextBlockType.Text, Text = "You are haunted by all those you have killed." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f99aaf71-da16-45d1-95fe-027a66681281"),
                SourceId = GamemasteryGuide.ID,
                Page = 116
            };
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Curse.ID;
            yield return Magical.ID;
            yield return Illusion.ID;
            yield return Visual.ID;
        }
    }
}
