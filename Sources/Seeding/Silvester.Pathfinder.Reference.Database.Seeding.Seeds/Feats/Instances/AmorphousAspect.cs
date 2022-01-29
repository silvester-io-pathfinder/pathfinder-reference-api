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
    public class AmorphousAspect : Template
    {
        public static readonly Guid ID = Guid.Parse("832768a5-f754-42e2-93f7-527fd4cc38d5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Amorphous Aspect",
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
            yield return new TextBlock { Id = Guid.Parse("2a1a8630-dd49-4c37-aba6-a52197a9ebef"), Type = TextBlockType.Text, Text = $"Your body is supremely flexible. You gain a +1 circumstance bonus on checks to {ToMarkdownLink<Models.Entities.Action>("Escape", Actions.Instances.Escape.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Squeeze", SkillActions.Instances.Squeeze.ID)}, and when you critically fail when {ToMarkdownLink<Models.Entities.SkillAction>("Squeezing", SkillActions.Instances.Squeeze.ID)}, you get a failure instead." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f8c339dc-6965-4241-9805-71482ae0fad7"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
