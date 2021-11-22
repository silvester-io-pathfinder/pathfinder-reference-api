using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ContinualRecovery : Template
    {
        public static readonly Guid ID = Guid.Parse("7d8344b3-0bf4-41f7-a516-278b81110515");

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
            yield return new TextBlock { Id = Guid.Parse("fda3026f-8dcc-4c4b-a332-0b3e055902cb"), Type = TextBlockType.Text, Text = "You zealously monitor a patient's progress to administer treatment faster. When you (Action: Treat Wounds), your patient becomes immune for only 10 minutes instead of 1 hour. This applies only to your (Action: Treat Wounds) activities, not any other the patient receives." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("4d556f20-c66d-43f2-8a5d-a9846226e1dd"), Proficiencies.Instances.Expert.ID, Skills.Instances.Medicine.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("10782a1c-aa7d-47ee-b974-c14c84bf3878"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
