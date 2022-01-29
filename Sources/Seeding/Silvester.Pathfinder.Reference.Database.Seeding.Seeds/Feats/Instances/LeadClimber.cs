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
    public class LeadClimber : Template
    {
        public static readonly Guid ID = Guid.Parse("0cf588b1-3969-4e0d-bd94-4dea364be141");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lead Climber",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8454c4c0-c02b-425c-ab58-1e0bcbfceee6"), Type = TextBlockType.Text, Text = $"When climbing, you can prepare routes for others to follow, and you can pull your allies up to avoid disaster. When your allies attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Climb", SkillActions.Instances.Climb.ID)} a route you set using the {ToMarkdownLink<Models.Entities.Activity>("Follow the Expert", Activities.Instances.FollowTheExpert.ID)} exploration activity, if any of them critically fail their checks to {ToMarkdownLink<Models.Entities.SkillAction>("Climb", SkillActions.Instances.Climb.ID)}, you can attempt an Athletics check against the same DC. If you succeed, your ally fails instead of critically failing. If you also critically fail, you both experience the consequences of the critical failure." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("25cc4d54-d513-4b57-8bb8-8ab7be20f893"), Proficiencies.Instances.Expert.ID, Skills.Instances.Athletics.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.General.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8b082bd1-cb0d-4184-b65b-725906d36b93"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
