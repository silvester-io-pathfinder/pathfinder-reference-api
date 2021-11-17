using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PerfectDistraction : Template
    {
        public static readonly Guid ID = Guid.Parse("169a7bff-f672-4356-accb-ea226c04d194");

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
            yield return new TextBlock { Id = Guid.Parse("6e41eee9-1c95-44a6-b1be-7841e8342bba"), Type = TextBlockType.Text, Text = "You use clever tactics to mislead your foes as you sneak away. You (action: Sneak) while leaving a decoy behind. The decoy acts as the spell (spell: mislead), though you aren’t invisible, just undetected. You can continue to concentrate to move your decoy, as with the spell, whether or not you remain hidden throughout the duration. Once you use Perfect Distraction, you need to spend 10 minutes to set up another decoy before you can use it again." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("85a1ba5e-7301-4525-8ef5-dc2f447f7f1c"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Deception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0e84561b-6c89-43af-9b0a-0fb8f0163f07"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
