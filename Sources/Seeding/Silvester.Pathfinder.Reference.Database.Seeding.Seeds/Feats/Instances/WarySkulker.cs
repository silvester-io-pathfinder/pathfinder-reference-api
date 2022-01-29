using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WarySkulker : Template
    {
        public static readonly Guid ID = Guid.Parse("f297113f-6e79-46be-bda5-a9ece1d24c7b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wary Skulker",
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
            yield return new TextBlock { Id = Guid.Parse("5c83752d-9ae4-4692-97e4-43fa81e224f8"), Type = TextBlockType.Text, Text = $"Ever alert, you scout for danger even when you are trying to stay hidden. You can perform the {ToMarkdownLink<Models.Entities.Activity>("Scout", Activities.Instances.Scout.ID)} exploration activity at the same time as the {ToMarkdownLink<Models.Entities.Activity>("Avoid Notice", Activities.Instances.AvoidNotice.ID)} exploration activity." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("c2fd349a-ac80-4978-8168-0abdeda1a00b"), Traits.Instances.Catfolk.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("22d8267f-ee41-4746-b235-b6dbe71587d7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
