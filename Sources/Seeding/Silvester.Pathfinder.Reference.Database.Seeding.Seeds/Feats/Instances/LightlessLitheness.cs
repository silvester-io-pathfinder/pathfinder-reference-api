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
    public class LightlessLitheness : Template
    {
        public static readonly Guid ID = Guid.Parse("639c17a2-fcb0-4ade-9ef8-0233d8322982");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lightless Litheness",
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
            yield return new TextBlock { Id = Guid.Parse("3c469e7d-52d8-4d4d-8aaa-fdb0dbb9290a"), Type = TextBlockType.Text, Text = $"Your body is almost as flexible as your shadow. When you critically fail at {ToMarkdownLink<Models.Entities.SkillAction>("Squeezing", SkillActions.Instances.Squeeze.ID)}, you get a failure instead. Additionally, when you roll a success at an {ToMarkdownLink<Models.Entities.Action>("Escape", Actions.Instances.Escape.ID)} check, you get a critical success instead; if you roll a critical success, you can {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)} instead of {ToMarkdownLink<Models.Entities.Action>("Striding", Actions.Instances.Stride.ID)} up to 5 feet." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d7e60ff4-66d1-4bca-9f71-c4e3ad6c13ed"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
