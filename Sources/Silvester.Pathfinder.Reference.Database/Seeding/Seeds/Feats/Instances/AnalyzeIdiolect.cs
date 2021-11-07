using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnalyzeIdiolect : Template
    {
        public static readonly Guid ID = Guid.Parse("9ca477a0-b095-49d0-870b-f098268246b7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Analyze Idiolect",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("05e8a742-fd92-41f6-ba00-c9ff42a7e70f"), Type = TextBlockType.Text, Text = "You break down a specific individual’s idiolect, memorizing their speech mannerisms and habits. If you interact with someone for at least 10 minutes, when you later attempt to (action: Impersonate) that individual, you gain a +4 circumstance bonus to your Deception checks and DCs. Due to the intense character study required, you can’t remember more than one idiolect at a time." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6967b06b-0bb0-4137-b286-0a79ae1b8c24"), Feats.Instances.LinguistDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("6d7ec259-724e-4430-a47a-4257cd850c90"), Proficiencies.Instances.Expert.ID, Skills.Instances.Deception.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("454adc41-2aa5-487a-8b5e-b707afca2d83"), Proficiencies.Instances.Expert.ID, Skills.Instances.Society.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("69c4da46-e974-4a21-a1e1-784cdf79322a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
