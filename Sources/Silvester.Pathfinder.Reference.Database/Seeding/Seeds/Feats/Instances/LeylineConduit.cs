using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LeylineConduit : Template
    {
        public static readonly Guid ID = Guid.Parse("b94e3689-b184-47d9-aa5d-c89fa3217120");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Leyline Conduit",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d5520478-63eb-4161-98c9-46ad841cbc34"), Type = TextBlockType.Text, Text = "You can cast your spells effortlessly by tapping into the leylines of the world. If your next action is to (activity: Cast a Spell) of 5th level or lower that has no duration, you don’t expend the prepared spell as you cast it." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("83908fff-9271-4fbc-9738-1a12cf66b470"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
