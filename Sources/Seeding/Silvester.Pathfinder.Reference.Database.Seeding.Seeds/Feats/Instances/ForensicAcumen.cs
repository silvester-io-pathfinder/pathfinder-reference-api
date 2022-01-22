using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ForensicAcumen : Template
    {
        public static readonly Guid ID = Guid.Parse("f71ee019-38a4-461f-a4f6-e75ee7bede76");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Forensic Acumen",
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
            yield return new TextBlock { Id = Guid.Parse("8ceec188-aa31-465e-ba42-89c58bbf249b"), Type = TextBlockType.Text, Text = $"You understand the principles of forensic medicine, making you better at examining a body to determine the cause of death or injury. You can perform a forensic examination on a body, as described under {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} in the Medicine skill, in half the normal amount of time it would take (to a minimum of 5 minutes). If you succeed at your check, you can attempt an immediate check to {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} to follow up on something you found, with a +2 circumstance bonus. This check is usually related to the cause of injury or death, such as a Crafting check to identify a poison or weapon that was used or an additional Medicine check to identify a specific disease. If you prefer, you can instead attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} about the type of creature whose body you were examining, using the appropriate skill and gaining the same circumstance bonus." };
            yield return new TextBlock { Id = Guid.Parse("063a491a-d132-429c-92c4-03e71ff17f38"), Type = TextBlockType.Text, Text = $"The circumstance bonus increases to +3 if you have master proficiency in Medicine and +4 if you have legendary proficiency." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("b35fc895-e952-47cb-8287-6fce02c38920"), Proficiencies.Instances.Trained.ID, Skills.Instances.Medicine.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("be1fdc55-4d88-4882-a3e1-2cefe479b16f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
