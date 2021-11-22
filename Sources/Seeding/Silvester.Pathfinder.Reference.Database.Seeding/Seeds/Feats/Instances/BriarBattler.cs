using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BriarBattler : Template
    {
        public static readonly Guid ID = Guid.Parse("02a25143-771d-4035-994f-85383b7be464");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Briar Battler",
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
            yield return new TextBlock { Id = Guid.Parse("ce92491e-f9c4-4cf0-ad2d-ca830c397a01"), Type = TextBlockType.Text, Text = "You've learned to use roots, crevices, uneven ground, and dense underbrush to your advantage. When you're in difficult terrain from an environmental feature, you can (action: Take Cover), even if the feature wouldn't ordinarily be large enough for you to (action: Take Cover)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8d443df2-9785-4f6e-bba9-31884450a3ff"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
