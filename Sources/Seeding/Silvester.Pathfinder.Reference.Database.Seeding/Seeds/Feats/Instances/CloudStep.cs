using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CloudStep : Template
    {
        public static readonly Guid ID = Guid.Parse("e65894b8-bbc6-41ef-8bfe-dab5ff67e209");

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
            yield return new TextBlock { Id = Guid.Parse("8f7e362b-8a30-406d-9ddd-84f3e1e2ac07"), Type = TextBlockType.Text, Text = "Using fantastic acrobatic skill, you can walk for brief stretches across insubstantial surfaces. When you (action: Stride), you can move across water, air, and solid surfaces that can hold only limited weight as if they were normal ground. If you (action: Stride) over a trap with a weight-sensitive pressure plate, you don't trigger it. At the end of your turn, you sink, fall, break fragile surfaces, or trigger traps as normal for your current location." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("c646f794-f332-4fbc-9f02-0a92ec519d85"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Acrobatics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("513e6031-dad7-47f2-9466-18aeb9ff0274"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
