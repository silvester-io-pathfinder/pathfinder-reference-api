using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HybridShape : Template
    {
        public static readonly Guid ID = Guid.Parse("ddd9ae12-659e-458d-81b9-88a3ca646931");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hybrid Shape",
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
            yield return new TextBlock { Id = Guid.Parse("e2f9bda4-96f5-451f-b86f-a0b92da813ca"), Type = TextBlockType.Text, Text = "Mastery of your shapeshifting lets you combine the best features of your humanoid and spider forms. When using your (action: Change Shape | Change Shape - Anadi) ability, you can assume a bipedal hybrid shape. This form gains all the benefits of your spider shape as well as the ability to use items and take (trait: manipulate) actions just as easily as your human shape." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6d650a74-476f-4907-9f78-c7209675028a"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
