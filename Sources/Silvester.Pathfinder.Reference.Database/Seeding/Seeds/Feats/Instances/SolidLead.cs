using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SolidLead : Template
    {
        public static readonly Guid ID = Guid.Parse("7ea1493d-dcb8-4f9c-8104-733a21ec8893");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Solid Lead",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f8575cd2-f41f-42d7-ab0c-19cec43cf55c"), Type = TextBlockType.Text, Text = "Sometimes your case splinters into smaller mysteries, but you never lose sight of the big picture. Once per day when you give up on the subject of a lead due to using (action: Pursue a Lead) again, you can designate the lead you stopped pursuing as your solid lead for the day. Even though you stopped following the solid lead, you can change back to your solid lead any number of times by using a single action, which has the (trait: concentrate) trait. Doing so ends one of your current leads as normal." };
            yield return new TextBlock { Id = Guid.Parse("09609238-e288-4146-a1ac-3a54ece2e1b6"), Type = TextBlockType.Text, Text = "During your next daily preparations, you can maintain your solid lead or you can remove it; removing it allows you to designate a new solid lead later that day." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("48cf4c01-aa9f-499b-96a7-69ec5d858393"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
