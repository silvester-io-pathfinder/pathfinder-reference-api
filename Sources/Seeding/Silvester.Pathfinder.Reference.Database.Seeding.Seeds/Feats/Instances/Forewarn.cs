using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Forewarn : Template
    {
        public static readonly Guid ID = Guid.Parse("6b18a9ec-f044-4f59-85a9-d1ebc8f58db3");

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
            yield return new TextBlock { Id = Guid.Parse("a3ffd8d4-1b7b-491d-9c16-76b2ac52c00f"), Type = TextBlockType.Text, Text = $"Your foresight and planning are more valuable than armor as you direct your ally away from danger, but there's a limit to how often you can guide your allies away from a foe's relentless assaults. The triggering attack roll targets your Perception DC instead of your ally's AC. Though this allows your ally to avoid taking penalties to their AC, it doesn't remove any conditions or other effects causing such penalties. For example, an enemy with sneak attack would still deal extra damage to your ally if they are flat-footed, even though they wouldn't take the –2 circumstance penalty when defending against the attack." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0a16a14d-46d8-4641-a277-fd2541ebe7b7"), Feats.Instances.OverwatchDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("bb44eb79-f247-4236-a3e9-e3a94489a94f"), Proficiencies.Instances.Master.ID, Skills.Instances.Perception.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e2c1a142-caf9-4520-adbf-e25c4fccd8ce"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
