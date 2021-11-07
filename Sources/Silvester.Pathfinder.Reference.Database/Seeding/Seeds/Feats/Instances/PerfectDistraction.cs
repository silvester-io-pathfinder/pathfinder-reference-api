using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PerfectDistraction : Template
    {
        public static readonly Guid ID = Guid.Parse("a541671e-1413-40e8-a6b3-e8074934ae8a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Perfect Distraction",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9599d7b5-b47d-4885-ae62-73c529b3172d"), Type = TextBlockType.Text, Text = "You use clever tactics to mislead your foes as you sneak away. You (action: Sneak) while leaving a decoy behind. The decoy acts as the spell (spell: mislead), though you aren’t invisible, just undetected. You can continue to concentrate to move your decoy, as with the spell, whether or not you remain hidden throughout the duration. Once you use Perfect Distraction, you need to spend 10 minutes to set up another decoy before you can use it again." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("33688a30-8713-42c6-8423-21eaf60dd3f6"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Deception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("798c5e89-a49f-4ade-86bb-dd6f69d63f9b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
