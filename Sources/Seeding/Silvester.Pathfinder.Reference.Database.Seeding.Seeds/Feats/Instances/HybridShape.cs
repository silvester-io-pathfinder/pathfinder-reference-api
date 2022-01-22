using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HybridShape : Template
    {
        public static readonly Guid ID = Guid.Parse("46da0114-6c1a-4d73-996f-42d2dd3efd46");

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
            yield return new TextBlock { Id = Guid.Parse("01fb0927-f4c8-4757-a96d-513e5c2a0b6a"), Type = TextBlockType.Text, Text = $"Mastery of your shapeshifting lets you combine the best features of your humanoid and spider forms. When using your {ToMarkdownLink<Models.Entities.Feat>("Change Shape", Feats.Instances.ChangeShapeAnadi.ID)} ability, you can assume a bipedal hybrid shape. This form gains all the benefits of your spider shape as well as the ability to use items and take {ToMarkdownLink<Models.Entities.Trait>("manipulate", Traits.Instances.Manipulate.ID)} actions just as easily as your human shape." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ff13870e-16f2-4d18-bb4c-9415977f2ea7"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
