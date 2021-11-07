using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShrinkDown : Template
    {
        public static readonly Guid ID = Guid.Parse("5725b0f7-00ea-491a-97e5-4d94ba293883");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shrink Down",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("963c1517-8dec-4438-9391-58e268fef47e"), Type = TextBlockType.Text, Text = "Your eidolon can shrink to fit into small spaces. Your eidolon reduces in size, to a minimum of size Small. It can use this action again while shrunk to return to its normal size." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("91e27ef1-1923-456d-bc00-07bec3793369"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
