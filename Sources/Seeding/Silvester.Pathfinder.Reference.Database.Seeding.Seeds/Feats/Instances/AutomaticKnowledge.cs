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
    public class AutomaticKnowledge : Template
    {
        public static readonly Guid ID = Guid.Parse("89ec6840-539f-480e-a09a-c0aba47f3bb8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Automatic Knowledge",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat multiple times, choosing a different skill each time. You can use Automatic Knowledge with any skills you have chosen, but you can still use Automatic Knowledge only once per round.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0bc39f82-d473-4a3d-986b-8b06ed6f3eec"), Type = TextBlockType.Text, Text = $"You know basic facts off the top of your head. When you select this feat, choose a skill you're an expert in that has the {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} action and for which you have the {ToMarkdownLink<Models.Entities.Feat>("Assurance", Feats.Instances.Assurance.ID)} feat. You can use the {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} action with that skill as a free action once per round. If you do, you must use {ToMarkdownLink<Models.Entities.Feat>("Assurance", Feats.Instances.Assurance.ID)} on the skill check." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificRecallKnowledgeProficiency(Guid.Parse("8d325c21-af10-4b18-b6f3-8d916c34edfe"), Proficiencies.Instances.Expert.ID, requiresAssurance: true);
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
                Id = Guid.Parse("2a9aa822-5db2-4538-a21e-0c149e2b4799"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
