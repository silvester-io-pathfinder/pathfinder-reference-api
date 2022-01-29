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
    public class MobileFinisher : Template
    {
        public static readonly Guid ID = Guid.Parse("577c36bb-a63a-4d0f-a0b7-eae14ea2b26c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mobile Finisher",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1e7a5d11-59e3-4bb2-9474-d144a3b9f32e"), Type = TextBlockType.Text, Text = $"You attack in motion. {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} and then {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. You can use Mobile Finisher while {ToMarkdownLink<Models.Entities.Action>("Burrowing", Actions.Instances.Burrow.ID)}, {ToMarkdownLink<Models.Entities.SkillAction>("Climbing", SkillActions.Instances.Climb.ID)}, {ToMarkdownLink<Models.Entities.Action>("Flying", Actions.Instances.Fly.ID)}, or {ToMarkdownLink<Models.Entities.SkillAction>("Swimming", SkillActions.Instances.Swim.ID)} instead of {ToMarkdownLink<Models.Entities.Action>("Striding", Actions.Instances.Stride.ID)} if you have the corresponding movement type." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Finisher.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Swashbuckler.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ee2f68b6-de89-431b-8a8d-6f2c9ec49f90"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
