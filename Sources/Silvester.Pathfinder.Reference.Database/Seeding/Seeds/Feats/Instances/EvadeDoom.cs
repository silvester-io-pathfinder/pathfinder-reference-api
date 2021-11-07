using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EvadeDoom : Template
    {
        public static readonly Guid ID = Guid.Parse("65e6f9bb-027c-4a02-8f64-cc08ea5fdb12");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Evade Doom",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9e8c1c40-9ec3-4943-ae75-bff1d950a749"), Type = TextBlockType.Text, Text = "You can elude supernatural disaster. When you would gain the doomed condition, you can attempt a DC 17 flat check. On a success, you don’t gain the doomed condition." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("83e70c79-4f82-4f6a-98f2-cdeeb443695e"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
