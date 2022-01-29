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
    public class RingmastersIntroduction : Template
    {
        public static readonly Guid ID = Guid.Parse("07549e7d-da83-40e0-a469-d8233d695238");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ringmaster's Introduction",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An ally's turn begins.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e63e02c4-94da-4e8e-8a41-3dc4c34c1978"), Type = TextBlockType.Text, Text = $"You announce the triggering ally with a litany of their legendary achievements, spurring them to action. The target is quickened this turn and can spend the extra action to {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)}, {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, {ToMarkdownLink<Models.Entities.SkillAction>("Demoralize", SkillActions.Instances.Demoralize.ID)}, {ToMarkdownLink<Models.Entities.SkillAction>("Feint", SkillActions.Instances.Feint.ID)}, or {ToMarkdownLink<Models.Entities.SkillAction>("Perform", SkillActions.Instances.Perform.ID)}." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Bard.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("52f42cb0-7745-44e9-81df-401c67007202"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
