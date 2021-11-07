using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CloudStep : Template
    {
        public static readonly Guid ID = Guid.Parse("eb92906c-7453-4131-b1a9-7688d026e701");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cloud Step",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c77c48ed-d00b-48a9-9edd-c70291acf42d"), Type = TextBlockType.Text, Text = "Using fantastic acrobatic skill, you can walk for brief stretches across insubstantial surfaces. When you (action: Stride), you can move across water, air, and solid surfaces that can hold only limited weight as if they were normal ground. If you (action: Stride) over a trap with a weight-sensitive pressure plate, you don’t trigger it. At the end of your turn, you sink, fall, break fragile surfaces, or trigger traps as normal for your current location." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("5b347ab3-1f74-4868-90fb-f3fba863cafe"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Acrobatics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("64764821-7ff0-4b1d-87fa-760818f0e4c2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
