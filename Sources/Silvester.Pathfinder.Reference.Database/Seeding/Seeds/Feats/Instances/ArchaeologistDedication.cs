using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArchaeologistDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("f035878d-155f-4040-9c0b-0a280ee5cd61");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Archaeologist Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the archaeologist archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9c1b95b8-f317-457c-b9c2-0087f55a45bd"), Type = TextBlockType.Text, Text = "You are a student of peoples and their histories, and are in constant pursuit of knowledge and artifacts from the past. You become an expert in Society and Thievery, and you gain a +1 circumstance bonus to (action: Recall Knowledge) about ancient history, peoples, and cultures." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("1748bef8-c959-42c6-9790-0a736ca90693"), Proficiencies.Instances.Trained.ID, Skills.Instances.Perception.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("a2a6f864-3923-4b6c-87e7-e155f6ac3465"), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("f9997e73-e7b3-4f10-9549-7884f07d3c8c"), Proficiencies.Instances.Trained.ID, Skills.Instances.Thievery.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("83d0cb00-a3c7-4a66-8af9-b24bf6f4d75f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
