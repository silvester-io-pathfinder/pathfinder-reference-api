using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScarThickSkin : Template
    {
        public static readonly Guid ID = Guid.Parse("61a0293a-e0dc-4075-8594-326102577e94");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scar-Thick Skin",
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
            yield return new TextBlock { Id = Guid.Parse("a1b0f8c8-8f7a-4e0e-aebf-f0707f8fd641"), Type = TextBlockType.Text, Text = $"Glorious, storied scars cover and protect much of your body. Your DC on flat checks to end persistent bleed damage is reduced from 15 to 10, or from 10 to 5 after receiving especially appropriate assistance." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c0228d5c-98af-4fda-88fd-17d92ead56e5"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
