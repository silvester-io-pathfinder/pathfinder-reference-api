using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LeaveAnOpening : Template
    {
        public static readonly Guid ID = Guid.Parse("029ddea4-2da1-4092-9a1d-514c897744d0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Leave an Opening",
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
            yield return new TextBlock { Id = Guid.Parse("ce55307a-d42b-4cb7-84b2-a190d4bb9f07"), Type = TextBlockType.Text, Text = "When you hit hard enough, you leave an opening so your ally can jump in on the action. Whenever you critically hit a flat-footed opponent with a melee attack and deal damage, the target triggers an (feat: Attack of Opportunity) reaction from one ally of your choice who has that reaction, as if the enemy had used a manipulate action." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9a1e8da9-e892-48a7-962f-3449210e3622"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
