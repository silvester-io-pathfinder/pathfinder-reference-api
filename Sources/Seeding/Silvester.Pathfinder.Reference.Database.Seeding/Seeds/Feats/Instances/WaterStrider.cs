using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WaterStrider : Template
    {
        public static readonly Guid ID = Guid.Parse("c7ded73a-4896-4eb9-a8cd-acf969d8a275");

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
            yield return new TextBlock { Id = Guid.Parse("947f3e94-d0e0-46bf-b78f-c7fd4f96afc5"), Type = TextBlockType.Text, Text = "Water cradles your every step, allowing you to walk on its surface. (action: Stride) up to your Speed. During your movement, you can move across liquids that don’t support your weight. If you end your movement on a surface that can’t support you, you fall into the liquid at the end of your movement. You can increase the number of actions to 3 to (action: Stride) up to three times your Speed." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2195595b-1223-4ace-bfca-4096ff94e82f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
