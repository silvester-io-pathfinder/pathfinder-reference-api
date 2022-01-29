using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WardensGuidance : Template
    {
        public static readonly Guid ID = Guid.Parse("b7c88254-c3d8-4352-a6ba-30f9556a5ac5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Warden's Guidance",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7996448e-7810-462f-bd6d-c4c162c87eff"), Type = TextBlockType.Text, Text = $"You can convey your prey's location to your allies, no matter how well hidden it is. As long as your hunted prey is observed by you, all your allies who roll failures and critical failures when {ToMarkdownLink<Models.Entities.Action>("Seeking", Actions.Instances.Seek.ID)} it get a success instead. Your allies need to be able to see or hear you to gain this benefit. You have to be able to call out or use gestures for your allies to get this benefit." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b3734e3d-3516-44e3-a585-c2805e64b602"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
