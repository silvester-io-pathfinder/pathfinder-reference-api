using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RepairModule : Template
    {
        public static readonly Guid ID = Guid.Parse("72daeb16-c1a5-418a-811a-c9c0e88da1cd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Repair Module",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1a6f06ce-5d27-4a19-88eb-aee7864d6fab"), Type = TextBlockType.Text, Text = "You trigger your body’s repair programming, causing your body’s nanites to heal your wounds. You gain fast healing equal to half your level for 1 minute. While Repair Module is active, you can’t use other abilities that require the use of your nanites." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fa1ca1f8-384b-4a43-8db8-2124235b59fe"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
