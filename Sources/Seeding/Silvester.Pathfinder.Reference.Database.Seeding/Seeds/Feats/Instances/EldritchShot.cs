using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EldritchShot : Template
    {
        public static readonly Guid ID = Guid.Parse("3141baa8-8d10-451e-974a-624b11d2d68f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eldritch Shot",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("81984c55-cf9c-4167-8aa4-e06433ac80f5"), Type = TextBlockType.Text, Text = "You (activity: Cast a Spell) that takes 1 or 2 actions to cast and requires a spell attack roll. The effects of the spell do not occur immediately but are imbued into the bow you're wielding." };
            yield return new TextBlock { Id = Guid.Parse("c6b9d991-a89c-408c-944f-304e723e310a"), Type = TextBlockType.Text, Text = "Make a (action: Strike) with that bow. Your spell flies with the ammunition, using your attack roll result to determine the effects of both the (action: Strike) and the spell. This counts as two attacks for your multiple attack penalty, but you don't apply the penalty until after you've completed both attacks." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("11927fef-d0e1-48cc-85ca-d9c14b58f35d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
