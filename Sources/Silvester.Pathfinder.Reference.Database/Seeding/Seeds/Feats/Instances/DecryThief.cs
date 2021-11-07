using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DecryThief : Template
    {
        public static readonly Guid ID = Guid.Parse("9874fde6-3b30-4c4c-98ab-955c500eab05");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Decry Thief",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d4744c7e-7d6b-4e4f-b164-53d1f5341ac8"), Type = TextBlockType.Text, Text = "When you attempt to (action: Demoralize), you can make it harder for the target to flee, in place of the action’s normal effects." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1da37d02-38af-4dac-9959-fa0b1c472b6d"), Feats.Instances.ZephyrGuardDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("1f99a307-0f4d-4161-8440-0329668833fa"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("5e82f828-292a-44e2-892f-169e5eba708d"),
                CriticalSuccess = "For 1 round, the target takes a -10-foot status penalty to Speed and a -4 status penalty to Stealth.",
                Success = "For 1 round, the target takes a -5-foot status penalty to Speed and a -2 status penalty to Stealth.",
                
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cf472382-956d-4d3a-ada2-681612f919a4"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
