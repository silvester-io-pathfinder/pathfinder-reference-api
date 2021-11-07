using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Twitchy : Template
    {
        public static readonly Guid ID = Guid.Parse("362f282b-8c00-465c-8dd7-0f2c5d820d94");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Twitchy",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("38f954bc-c1d7-4507-b603-14bd0693332c"), Type = TextBlockType.Text, Text = "You are naturally suspicious and wary of danger, especially when you suspect someone might be leading you into an ambush. You gain a +1 circumstance bonus to AC and saves against hazards, and to all of your initiative rolls. If at least one of your opponents is using Deception or Diplomacy to determine their initiative, your bonus to initiative from this feat increases to +4." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("64d62e36-096c-4788-bf68-a4a2627c6588"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
