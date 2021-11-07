using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Doublespeak : Template
    {
        public static readonly Guid ID = Guid.Parse("45f66b1d-ac5f-4058-a786-55d682b9adbc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Doublespeak",
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
            yield return new TextBlock { Id = Guid.Parse("37eea497-4ff9-43f0-ba0a-62a498abcfcc"), Type = TextBlockType.Text, Text = "You are skilled at saying one thing while meaning something different. You disguise your true meaning behind other words and phrases, relying on subtle emphasis and shared experience to convey meaning that only your allies understand. Any allies who have traveled alongside you for at least 1 full week automatically discern your meaning. Other observers must succeed at a Perception check against your Deception DC to realize you are passing a secret message, and they must critically succeed to understand the message itself." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("cac1fae6-2757-42b1-85bc-47d5f6c85261"), Proficiencies.Instances.Master.ID, Skills.Instances.Deception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5d6e541d-e2ad-4337-8762-b739a6ae8746"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
