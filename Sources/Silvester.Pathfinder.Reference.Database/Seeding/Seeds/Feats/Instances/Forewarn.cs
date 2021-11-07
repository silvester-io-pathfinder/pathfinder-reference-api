using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Forewarn : Template
    {
        public static readonly Guid ID = Guid.Parse("8472e633-5755-4a6e-a0dc-82f288f43483");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Forewarn",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An enemy within your overwatch field attempts an attack against an ally who is also within your overwatch field.",
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("04ad7c27-4a9f-465d-a0fc-61963dae8c9b"), Type = TextBlockType.Text, Text = "Your foresight and planning are more valuable than armor as you direct your ally away from danger, but there’s a limit to how often you can guide your allies away from a foe’s relentless assaults. The triggering attack roll targets your Perception DC instead of your ally’s AC. Though this allows your ally to avoid taking penalties to their AC, it doesn’t remove any conditions or other effects causing such penalties. For example, an enemy with sneak attack would still deal extra damage to your ally if they are flat-footed, even though they wouldn’t take the –2 circumstance penalty when defending against the attack." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9e9446f6-9468-4e8b-974a-acc6570868d1"), Feats.Instances.OverwatchDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("7614292e-fb9f-498e-b172-3666971642ca"), Proficiencies.Instances.Master.ID, Skills.Instances.Percepton.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aebdc103-e9df-4072-8af3-2b971ffe7600"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
