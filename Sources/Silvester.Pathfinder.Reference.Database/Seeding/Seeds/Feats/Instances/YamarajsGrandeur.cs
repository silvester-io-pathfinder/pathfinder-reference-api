using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class YamarajsGrandeur : Template
    {
        public static readonly Guid ID = Guid.Parse("b1476dd0-26c6-44b2-9d26-7204b6bc532c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Yamaraj's Grandeur",
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
            yield return new TextBlock { Id = Guid.Parse("1202e930-db21-4c6c-b9df-ea7ea56549c6"), Type = TextBlockType.Text, Text = "You have been granted a sliver of the power of the yamaraj, the magistrates of the dead who agreed to allow duskwalkers to exist at all. You exhale a blast of icy wind and ravenous insects. This is a 30-foot cone that deals 14d6 slashing damage and 4d6 persistent slashing damage (basic Reflex save using your class DC or spell DC, whichever is higher). On a critical failure, targets also become sickened 2." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d480c7e2-f6d9-4789-b399-ed03e931b0e5"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
