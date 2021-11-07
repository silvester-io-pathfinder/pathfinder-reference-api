using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WaterStrider : Template
    {
        public static readonly Guid ID = Guid.Parse("00cfeaf0-9786-4b7d-9b27-1a3b56aa370d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Water Strider",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9d012b5c-4439-4399-b155-3e2b36cac9f0"), Type = TextBlockType.Text, Text = "Water cradles your every step, allowing you to walk on its surface. (action: Stride) up to your Speed. During your movement, you can move across liquids that don’t support your weight. If you end your movement on a surface that can’t support you, you fall into the liquid at the end of your movement. You can increase the number of actions to 3 to (action: Stride) up to three times your Speed." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7219fe2b-b92f-4e58-917a-7e1ccc56fc4f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
