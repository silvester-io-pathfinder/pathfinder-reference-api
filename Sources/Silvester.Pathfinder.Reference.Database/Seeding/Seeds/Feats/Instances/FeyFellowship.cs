using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FeyFellowship : Template
    {
        public static readonly Guid ID = Guid.Parse("1c1c49c1-c8a8-4a9c-85a2-300159ed7075");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fey Fellowship",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If you have the Glad-Hand skill feat, you don't take the penalty on your immediate Diplomacy check if the target is a fey.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a3d9155a-c22d-4179-b800-b94ced2bd00e"), Type = TextBlockType.Text, Text = "Your enhanced fey connection affords you a warmer reception from creatures of the First World as well as tools to foil their tricks. You gain a +2 circumstance bonus to both Perception checks and saving throws against fey." };
            yield return new TextBlock { Id = Guid.Parse("49f96ae6-71a8-4ec2-8210-04c7417a507d"), Type = TextBlockType.Text, Text = "In addition, whenever you meet a fey creature in a social situation, you can immediately attempt a Diplomacy check to (Action: Make an Impression) on that creature rather than needing to converse for 1 minute. You take a -5 penalty to the check. If you fail, you can engage in 1 minute of conversation and attempt a new check at the end of that time rather than accepting the failure or critical failure result." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f274fc56-dccc-441b-93e2-22f4a2ac8ef8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
