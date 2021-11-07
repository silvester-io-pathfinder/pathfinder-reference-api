using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ContinualRecovery : Template
    {
        public static readonly Guid ID = Guid.Parse("4397d5b0-c562-4810-8931-a5eda3712f4f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Continual Recovery",
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
            yield return new TextBlock { Id = Guid.Parse("65dbd0e9-39ac-4e9d-aa5c-fc66b1fbd209"), Type = TextBlockType.Text, Text = "You zealously monitor a patient’s progress to administer treatment faster. When you (Action: Treat Wounds), your patient becomes immune for only 10 minutes instead of 1 hour. This applies only to your (Action: Treat Wounds) activities, not any other the patient receives." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("f787cf0f-3a44-41e7-bd65-c3e313e0f6e6"), Proficiencies.Instances.Expert.ID, Skills.Instances.Medicine.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0d43b195-d299-42a1-a787-9a08adba2fb8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
