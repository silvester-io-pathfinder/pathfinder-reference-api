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
    public class DanceOfThunder : Template
    {
        public static readonly Guid ID = Guid.Parse("ee4922b1-05dc-4487-87ec-e25ad473f5e1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dance of Thunder",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cfb67a9f-d656-4db9-abc6-7d3739f553f5"), Type = TextBlockType.Text, Text = $"Your steps echo with the thunderous retort of exploding black powder as you dance a dance of death. Take any of the following actions you choose in any order: {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)}, {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against a target within your firearm's first range increment, and {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} to reload. If you attempted a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} and it succeeded, you can repeat these three actions again in any order. If you attempted a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} in the second set and succeeded, you can repeat the actions one last time." };
            yield return new TextBlock { Id = Guid.Parse("01808168-91d1-4985-9628-ff24e5285740"), Type = TextBlockType.Text, Text = $"After using Dance of Thunder, you become fatigued for 1 minute." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2fe0b937-4f52-4d32-8292-65028a1aff47"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
