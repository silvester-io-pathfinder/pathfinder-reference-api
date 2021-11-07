using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HardToFool : Template
    {
        public static readonly Guid ID = Guid.Parse("3fbf8531-3258-4842-973f-4b1f165c9ea2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hard to Fool",
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
            yield return new TextBlock { Id = Guid.Parse("685675a7-c11e-4b6f-a185-29a4c9a24766"), Type = TextBlockType.Text, Text = "You’re accustomed to seeing through shifting darkness and bewildering magic. You gain a +1 circumstance bonus on Perception checks against illusions as well as to Will saves against illusions and (trait: shadow) effects." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("210673a3-fea0-4814-bdeb-b550e96cb245"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
