using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CallAndResponse : Template
    {
        public static readonly Guid ID = Guid.Parse("ac7dc7fb-ccf3-4579-ba3b-555564ebe255");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Call and Response",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("aa8e8611-eda5-4bf4-ba3c-3761bd3aa06b"), Type = TextBlockType.Text, Text = "Your composition takes the form of a call-and-response chant, which lets your allies continue the effect without you. If your next action is to cast a (trait: composition) cantrip with a duration of 1 round, it becomes a call. While the spell is active, one ally affected by the spell can respond to your call as a single action that has the (trait: auditory) and (trait: concentrate) traits to extend the spell’s duration by 1 round. Only one ally can respond to a given call, and responding to the ally’s response has no additional effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d9163c1f-4e77-4eb5-9a05-9f1916074300"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
