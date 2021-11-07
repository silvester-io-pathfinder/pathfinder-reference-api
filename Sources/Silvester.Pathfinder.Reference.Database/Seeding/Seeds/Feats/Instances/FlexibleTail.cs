using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FlexibleTail : Template
    {
        public static readonly Guid ID = Guid.Parse("6192f80a-9fc6-46d8-ad6b-e41d964cc436");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Flexible Tail",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("60b7bfc2-848f-42f1-9027-533b6f55f71c"), Type = TextBlockType.Text, Text = "You can perform simple (action: Interact) actions with your tail, such as opening an unlocked door. Your tail can’t perform actions that require fingers or significant manual dexterity, including any action that would require a check to accomplish, and you can’t use it to hold items." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bc7806b4-bc34-4478-bb7f-6f909e9f115a"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
