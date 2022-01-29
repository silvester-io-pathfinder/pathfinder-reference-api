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
    public class FabricatedConnections : Template
    {
        public static readonly Guid ID = Guid.Parse("176d450e-39f4-4048-8fa5-42b8d1e56ee4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fabricated Connections",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9b84309d-4ea8-4e6d-bad3-aec3d8db455a"), Type = TextBlockType.Text, Text = $"You can lie about having taken an action so convincingly that you acquire all the tangible benefits of having successfully completed it. You can roll Deception in place of a different skill when attempting to {ToMarkdownLink<Models.Entities.SkillAction>("Earn Income", SkillActions.Instances.EarnIncome.ID)}, {ToMarkdownLink<Models.Entities.SkillAction>("Make an Impression", SkillActions.Instances.MakeAnImpression.ID)}, {ToMarkdownLink<Models.Entities.SkillAction>("Request", SkillActions.Instances.Request.ID)}, or {ToMarkdownLink<Models.Entities.SkillAction>("Subsist", SkillActions.Instances.Subsist.ID)}. You can use Fabricated Connections to {ToMarkdownLink<Models.Entities.SkillAction>("Make an Impression", SkillActions.Instances.MakeAnImpression.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Request", SkillActions.Instances.Request.ID)} once per day, and you can also use it once per week to {ToMarkdownLink<Models.Entities.SkillAction>("Earn Income", SkillActions.Instances.EarnIncome.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Subsist", SkillActions.Instances.Subsist.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("15ec33d5-1a80-41f1-ace7-bc1ed5cfb638"), Feats.Instances.DandyDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("04949d3d-48e5-43ca-bd69-908808192246"), Proficiencies.Instances.Master.ID, Skills.Instances.Deception.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("90c5c57b-ac4f-49ea-ac4f-b86b9858704b"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("81c1a78c-e339-485d-8369-b10463028694"), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("02620479-cfd0-4cdc-a0f3-9fe71acc32d1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
