using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DevilsAdvocate : Template
    {
        public static readonly Guid ID = Guid.Parse("bef181a1-8686-4825-9f8a-39bd55f3b169");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Devil's Advocate",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If you have the (feat: Glad-Hand) skill feat, you don't take the penalty to your immediate Diplomacy check if the target is a devil.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b562f0c0-f186-4df7-8d03-3f07870cbd61"), Type = TextBlockType.Text, Text = "~ Access: Chelaxian nationality" };
            yield return new TextBlock { Id = Guid.Parse("e55e5536-4f3e-4054-b0a6-3301e4d85f5a"), Type = TextBlockType.Text, Text = "You know more about the habits of devils than is entirely safe. You gain a +2 circumstance bonus to Perception checks against devils and saving throws against their abilities. In addition, whenever you meet a devil in a social situation, you can immediately attempt a Diplomacy check to (action: Make an Impression) on that creature rather than needing to converse for 1 minute. You take a -5 penalty to the check. If you fail, you can engage in 1 minute of conversation and attempt a new check at the end of that time rather than accepting the failure or critical failure result." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("89ce7684-baa9-44ab-a2ea-fd656d385516"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
