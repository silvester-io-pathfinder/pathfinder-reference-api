using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IruxiSpiritStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("2d91e621-5894-4221-8be9-148573d4c998");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Iruxi Spirit Strike",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0e14e85f-5a6d-4c5e-87c3-35b060314cc1"), Type = TextBlockType.Text, Text = "Your iruxi unarmed attacks channel the spiritual energy of your ancestors. Any unarmed attacks you acquire from iruxi heritages or ancestry feats gain the effects of a (item: ghost touch | Ghost Touch Runestone) property rune." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ff9b44a7-bda6-419f-b8f5-c75fa1b64af5"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
