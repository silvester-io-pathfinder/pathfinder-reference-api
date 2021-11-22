using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BattleAssessment : Template
    {
        public static readonly Guid ID = Guid.Parse("92f016bb-25a1-46f1-acfd-841092771ac8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Battle Assessment",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9434dc3b-c6eb-4d4f-97b1-344c56ae01c8"), Type = TextBlockType.Text, Text = "With careful observation during battle, you identify an enemy's strengths and weaknesses. The GM rolls a secret Perception check for you against the Deception or Stealth DC (whichever is higher) of an enemy of your choice who is not concealed from you, hidden from you, or undetected by you, and who is engaged in combat. The GM might apply a penalty for the distance between you and the enemy. The enemy is then temporarily immune to your Battle Assessment for 1 day." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("4fadca6a-0363-4341-a0a5-cb64a98fa5c4"),
                CriticalSuccess = "The GM chooses two of the following pieces of information about the enemy to tell you: which of the enemy's weaknesses is highest, which of the enemy's saving throws has the lowest modifier, one immunity the enemy has, or which of the enemy's resistances is highest. If the event of a tie, the GM should pick one at random.",
                Success = "The GM chooses one piece of information from the above list to tell you about the enemy.",
                
                CriticalFailure = "The GM gives you false information (the GM makes up the information).", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("00d7d687-6fef-4b0c-b15a-9ca27b98a58d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
