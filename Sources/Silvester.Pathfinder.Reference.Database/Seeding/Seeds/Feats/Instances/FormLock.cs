using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FormLock : Template
    {
        public static readonly Guid ID = Guid.Parse("f4d5ef53-5b5b-4120-a001-088b8f7c43a2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Form Lock",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e7501f62-e0e9-4bf4-87a7-8e430e7b46d7"), Type = TextBlockType.Text, Text = "Your ability to control your own ki empowers you to pressure other creatures into resuming their true forms. Attempt an Athletics check to counteract a polymorph effect currently affecting your target. If the target is somehow under the effect of multiple polymorph effects, you can choose which one to attempt to counteract, or the GM chooses randomly if the separate effects aren’t obvious. The target is then temporarily immune for 1 day." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a6e1f692-518c-4542-9148-94ad3ff8e427"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
