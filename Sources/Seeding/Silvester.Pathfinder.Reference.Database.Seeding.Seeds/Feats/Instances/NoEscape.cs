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
    public class NoEscape : Template
    {
        public static readonly Guid ID = Guid.Parse("f1c68f17-e535-47ff-8885-ad5fddefa61b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "No Escape",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A foe within reach attempts to move away from you.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f34d2751-253b-4ed6-81ad-99b5fcde3652"), Type = TextBlockType.Text, Text = $"You keep pace with a retreating foe. {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} up to your Speed, following the foe and keeping it in reach throughout its movement until it stops moving or you've moved your full Speed. You can use No Escape to {ToMarkdownLink<Models.Entities.Action>("Burrow", Actions.Instances.Burrow.ID)}, {ToMarkdownLink<Models.Entities.SkillAction>("Climb", SkillActions.Instances.Climb.ID)}, {ToMarkdownLink<Models.Entities.Action>("Fly", Actions.Instances.Fly.ID)}, or {ToMarkdownLink<Models.Entities.SkillAction>("Swim", SkillActions.Instances.Swim.ID)} instead of {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} if you have the corresponding movement type." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Barbarian.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Rage.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f3015583-1fce-43df-a477-11a1831133e2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
