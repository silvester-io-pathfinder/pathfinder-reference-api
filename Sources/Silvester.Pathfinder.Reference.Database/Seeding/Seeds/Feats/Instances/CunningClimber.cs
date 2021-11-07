using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CunningClimber : Template
    {
        public static readonly Guid ID = Guid.Parse("91a2a613-d26a-4d5c-b95b-219a2355fb3c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cunning Climber",
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
            yield return new TextBlock { Id = Guid.Parse("c36647ee-5123-4706-a2d2-3eb01f2421fe"), Type = TextBlockType.Text, Text = "Whether you are climbing a ship’s rigging, a jungle tree, or a clock tower, you have an uncanny knack for finding footholds and handholds where larger creatures can’t. You gain a climb Speed of 10 feet. You can take the Legendary Climber feat even if you don’t have the (feat: Quick Climb) feat, provided you meet its other prerequisites." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cf455725-c269-4f7c-93e1-955a117550f8"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
