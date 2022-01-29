using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RallyingCry : Template
    {
        public static readonly Guid ID = Guid.Parse("326bbd17-4720-47ec-8768-7652b0122277");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rallying Cry",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b627f832-159c-4bfb-a4d2-115d2f930e2d"), Type = TextBlockType.Text, Text = $"You call out to your allies and push them to give their all in combat. All allies within 30 feet that can hear you gain a number of temporary Hit Points equal to your level. In addition, these allies become quickened for 1 minute but can only use the extra action to {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)}, {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)}, or {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5cf2f966-e95b-4b42-a551-3d2f90997b87"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
