using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnduringQuickness : Template
    {
        public static readonly Guid ID = Guid.Parse("d7d212f7-363f-42ae-a929-b1eada47f354");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Enduring Quickness",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4a48fbb4-0496-4719-ab58-90d84bc44fbd"), Type = TextBlockType.Text, Text = "You move as fast and as high as the wind itself. You’re permanently quickened. You can use your extra action to (action: Stride) or (action: Leap), or to provide one of the actions needed for a (action: High Jump) or (action: Long Jump)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8c66bda6-0cd7-4986-b9f6-04052e0a06e3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
