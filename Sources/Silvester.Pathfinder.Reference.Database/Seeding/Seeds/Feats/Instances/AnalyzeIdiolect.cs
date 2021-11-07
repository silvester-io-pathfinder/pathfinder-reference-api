using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnalyzeIdiolect : Template
    {
        public static readonly Guid ID = Guid.Parse("6ede6050-a7dc-4d33-a4c8-804fd5955cec");

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
            yield return new TextBlock { Id = Guid.Parse("2f6ccaea-864b-4934-b1b5-e7068224ee08"), Type = TextBlockType.Text, Text = "You break down a specific individual’s idiolect, memorizing their speech mannerisms and habits. If you interact with someone for at least 10 minutes, when you later attempt to (action: Impersonate) that individual, you gain a +4 circumstance bonus to your Deception checks and DCs. Due to the intense character study required, you can’t remember more than one idiolect at a time." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f500591b-7fd7-456c-84c6-aaa6cd5933c5"), Feats.Instances.LinguistDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("447c7fae-d09f-4f5a-9c46-0d703ee7bcd7"), Proficiencies.Instances.Expert.ID, Skills.Instances.Deception.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("8da5327f-67ee-43cf-a342-c73392bb1aaf"), Proficiencies.Instances.Expert.ID, Skills.Instances.Society.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a2422b63-070d-409a-845a-789a337a1e5c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
