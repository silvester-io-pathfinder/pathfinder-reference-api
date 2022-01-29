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
    public class SnowMay : Template
    {
        public static readonly Guid ID = Guid.Parse("aacc7ed7-fab2-4e78-8b4b-2021caf2c297");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Snow May",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ab43d22e-3a5d-4a2c-a1f5-4603a64b39cd"), Type = TextBlockType.Text, Text = $"You're the child of a winter hag, with one blue-white eye and an affinity for rime and snow. When moving over ice or snow in arctic terrain, you always gain the benefits of the {ToMarkdownLink<Models.Entities.SkillAction>("Cover Tracks", SkillActions.Instances.CoverTracks.ID)} action without needing to use the activity or having to move half your Speed. You don't treat icy terrain as uneven ground (though it's still difficult terrain for you), and you ignore difficult terrain caused by snow. Cold precipitation and environmental cold effects don't alter the time it takes for you to become fatigued." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Changeling.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Lineage.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b7d81313-45c8-48c6-a55d-9da3fedc6aba"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
