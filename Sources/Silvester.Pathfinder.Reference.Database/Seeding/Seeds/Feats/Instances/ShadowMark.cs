using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShadowMark : Template
    {
        public static readonly Guid ID = Guid.Parse("c2a69812-27f3-432f-a2f8-66cf19d06826");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shadow Mark",
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
            yield return new TextBlock { Id = Guid.Parse("96ef1ed6-29dd-41ce-a408-87b9c93291e9"), Type = TextBlockType.Text, Text = "You have learned special tricks that help you follow individuals without them noticing you. When you attempt a Stealth check to (action: Avoid Notice) while following a specific target, the target takes a -2 circumstance penalty to their Perception DC. If you have master proficiency in Stealth, the penalty is -3 or -4 if you’re legendary. If you start an encounter with the target while shadowing them, the target takes this penalty to their initiative roll and to their Perception DC to determine if they notice you, as normal for (action: Sneak)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("f3a67582-3746-47a3-87c5-3dc2627bb023"), Proficiencies.Instances.Expert.ID, Skills.Instances.Stealth.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dedf05ca-1c8e-4c55-bba7-aed74791eb99"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
