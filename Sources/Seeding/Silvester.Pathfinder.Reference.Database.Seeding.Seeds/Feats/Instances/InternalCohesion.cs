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
    public class InternalCohesion : Template
    {
        public static readonly Guid ID = Guid.Parse("f6fdc195-a0ab-4a11-a077-29ec7f3ad2b7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Internal Cohesion",
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
            yield return new TextBlock { Id = Guid.Parse("79cba7f7-42f0-4a27-89e7-da7dec66b267"), Type = TextBlockType.Text, Text = $"Axis's order suffuses your body and helps it maintain coherency. You and your allies can {ToMarkdownLink<Models.Entities.SkillAction>("Treat your Wounds", SkillActions.Instances.TreatWounds.ID)} without {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("healer's tools", Items.AdventuringGears.Instances.HealersTools.ID)}. Once per day, when someone rolls a failure or a critical failure on a check to {ToMarkdownLink<Models.Entities.SkillAction>("Treat your Wounds", SkillActions.Instances.TreatWounds.ID)}, you can focus on your internal cohesion to increase the degree of success by one step." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Aphorite.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("30411404-fb7c-4a1d-9ff4-8c13086ff139"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
