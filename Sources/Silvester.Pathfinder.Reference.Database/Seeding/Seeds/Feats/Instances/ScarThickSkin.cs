using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScarThickSkin : Template
    {
        public static readonly Guid ID = Guid.Parse("c09b1d19-5969-4629-bc85-4f3ea36fed63");

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
            yield return new TextBlock { Id = Guid.Parse("f10c54e1-b598-460e-86dc-4e92a3162e08"), Type = TextBlockType.Text, Text = "Glorious, storied scars cover and protect much of your body. Your DC on flat checks to end persistent bleed damage is reduced from 15 to 10, or from 10 to 5 after receiving especially appropriate assistance." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0a99f416-9059-4e75-96f5-531280458ade"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
