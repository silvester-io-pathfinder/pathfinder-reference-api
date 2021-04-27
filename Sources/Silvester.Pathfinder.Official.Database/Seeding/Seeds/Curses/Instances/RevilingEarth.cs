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
    public class RevilingEarth : AbstractCurseTemplate
    {
        public static readonly Guid ID = Guid.Parse("f9059558-883a-4d04-a080-5d5511da93de");

		public override Models.Curse GetCurse()
        {
            return new Models.Curse
            {
                Id = ID,
                Level = 12,
                Name = "Reviling Earth",
                DifficultyCheck = 30,
                SavingThrowStatId = Fortitude.ID,
                Effect = "When you enter the area, you become doomed 1, or doomed 2 on a critical failure."
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d84fc50c-1e94-4484-b4c3-108ec8336188"), Type = TextBlockType.Text, Text = "A reviling earth curse usually appears across a specific geographical region, such as a ruined town, a necromancer’s domain, or a similar area." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1b389a41-41cb-4710-9445-92dbc168b084"),
                SourceId = GamemasteryGuide.ID,
                Page = 117
            };
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Curse.ID;
            yield return Magical.ID;
            yield return Death.ID;
            yield return Necromancy.ID;
        }
    }
}
