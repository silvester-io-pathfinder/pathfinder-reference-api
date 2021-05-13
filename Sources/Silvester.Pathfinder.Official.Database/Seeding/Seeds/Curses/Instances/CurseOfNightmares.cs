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
    public class CurseOfNightmares : Template
    {
        public static readonly Guid ID = Guid.Parse("db1b4014-4933-49fb-919d-843c3fbeb5fb");

		public override Models.Curse GetCurse()
        {
            return new Models.Curse
            {
                Id = ID,
                Level = 2,
                Name = "Curse of Nightmares",
                DifficultyCheck = 16,
                SavingThrowStatId = Will.ID,
                Effect = "You must rest for 12 hours instead of 8 to avoid becoming fatigued and can’t gain any benefits from resting or long-term rest. You can still make your daily preparations."
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("21c4576f-e92a-4e83-83c4-2e122e7bd7a6"), Type = TextBlockType.Text, Text = "This curse plagues you with terrible nightmares whenever you sleep, preventing you from resting properly." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("edd40c4d-5455-4ad8-8937-09502b9f690f"),
                SourceId = GamemasteryGuide.ID,
                Page = 116
            };
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Curse.ID;
            yield return Magical.ID;
            yield return Illusion.ID;
            yield return Mental.ID;
        }
    }
}
