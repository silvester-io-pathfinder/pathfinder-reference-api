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
    public class AthleticMight : Template
    {
        public static readonly Guid ID = Guid.Parse("17202add-016a-477f-a81a-a0fae92c7c8c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Athletic Might",
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
            yield return new TextBlock { Id = Guid.Parse("437a7be7-b57e-4870-bfc3-c45c9f042c85"), Type = TextBlockType.Text, Text = $"Surviving in hostile terrain has given you a great talent for mobility. Whenever you roll a success on an Athletics check to {ToMarkdownLink<Models.Entities.SkillAction>("Climb", SkillActions.Instances.Climb.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Swim", SkillActions.Instances.Swim.ID)}, you get a critical success instead." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("7b115536-e2e7-4d4b-a606-c154594ddc5b"), Traits.Instances.Orc.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("311345a7-5100-4713-9e8f-b79a237b2d23"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
