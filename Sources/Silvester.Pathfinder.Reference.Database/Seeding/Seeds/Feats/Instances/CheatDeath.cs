using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CheatDeath : Template
    {
        public static readonly Guid ID = Guid.Parse("dea86426-2b12-4a7e-9d97-da98bb48578f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cheat Death",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You take damage that would reduce you to 0 Hit Points.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ba41349e-e0ee-4875-ba8c-793c89678a7c"), Type = TextBlockType.Text, Text = "Somehow you always escape the reaper by a hair’s breadth. You avoid being knocked out or killed and remain at 1 Hit Point, but you become doomed 1 (or increase your doomed value by 1 if you were already doomed). You can’t reduce or ignore the doomed condition from Cheating Death. The doomed condition from Cheating Death lasts for 10 minutes, though this doesn’t affect the duration of any other doomed condition you have." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4e70b25d-4c6b-4261-9ce4-dc72253d2d48"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
