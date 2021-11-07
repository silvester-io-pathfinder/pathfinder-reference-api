using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EldritchShot : Template
    {
        public static readonly Guid ID = Guid.Parse("145eb7b3-2144-4a63-9b26-ed868bcae3b4");

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
            yield return new TextBlock { Id = Guid.Parse("7a1d33b9-c6d8-4133-aba5-6392b9e70e8c"), Type = TextBlockType.Text, Text = "You (activity: Cast a Spell) that takes 1 or 2 actions to cast and requires a spell attack roll. The effects of the spell do not occur immediately but are imbued into the bow you’re wielding." };
            yield return new TextBlock { Id = Guid.Parse("0ad6e072-ec85-4cb6-89c3-3960fd60ac3d"), Type = TextBlockType.Text, Text = "Make a (action: Strike) with that bow. Your spell flies with the ammunition, using your attack roll result to determine the effects of both the (action: Strike) and the spell. This counts as two attacks for your multiple attack penalty, but you don’t apply the penalty until after you’ve completed both attacks." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7a177e0f-797d-40f3-9dd6-9218e23ed740"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
