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
    public class GladHand : Template
    {
        public static readonly Guid ID = Guid.Parse("3c950e1c-84f2-4331-ae09-26e357f9333b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Glad-Hand",
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
            yield return new TextBlock { Id = Guid.Parse("f4b1e7a9-18de-4c02-8558-c3a3317af17c"), Type = TextBlockType.Text, Text = $"First impressions are your strong suit. When you meet someone in a casual or social situation, you can immediately attempt a Diplomacy check to {ToMarkdownLink<Models.Entities.SkillAction>("Make an Impression", SkillActions.Instances.MakeAnImpression.ID)} on that creature rather than needing to converse for 1 minute. You take a -5 penalty to the check. If you fail or critically fail, you can engage in 1 minute of conversation and attempt a new check at the end of that time rather than accepting the failure or critical failure result." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("25f0613d-6ea1-4621-afe6-ec427ff16df5"), Proficiencies.Instances.Expert.ID, Skills.Instances.Diplomacy.ID);
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
                Id = Guid.Parse("2ecbba92-95e8-4d00-a8cf-c68522a387e2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
