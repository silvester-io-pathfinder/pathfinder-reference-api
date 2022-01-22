using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class JustTheFacts : Template
    {
        public static readonly Guid ID = Guid.Parse("ab40a632-4009-40d0-a733-677f5dc12300");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Just the Facts",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3695f3f5-90bd-41bb-9a9e-78da0d955389"), Type = TextBlockType.Text, Text = $"You fundamentally understand everything to the point where your research can't possibly be wrong. You are permanently quickened and can use the extra action only to {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)}. Your checks to {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} are no longer {ToMarkdownLink<Models.Entities.Trait>("secret", Traits.Instances.Secret.ID)}. When you {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)}, you use the outcome for one degree of success better than the result of your check, and if an effect (such as {ToMarkdownLink<Models.Entities.Feat>("Dubious Knowledge", Feats.Instances.DubiousKnowledge.ID)}) would give you inaccurate information from your {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} check, you know which information is inaccurate. When one of your allies {ToMarkdownLink<Models.Entities.SkillAction>("Recalls Knowledge", SkillActions.Instances.RecallKnowledge.ID)} and gains false information, you also know that information is inaccurate if they share it with you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d9abe9ec-2117-4061-9953-8e6eb7ae8fe6"), Feats.Instances.ThoroughResearch.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a35fcd44-20e6-40f4-8706-fb826dbdd1cd"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
