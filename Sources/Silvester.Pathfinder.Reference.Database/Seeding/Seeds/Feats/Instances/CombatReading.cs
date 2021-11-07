using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CombatReading : Template
    {
        public static readonly Guid ID = Guid.Parse("a66fcc54-a210-4e56-b67d-ad00c440c39e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Combat Reading",
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
            yield return new TextBlock { Id = Guid.Parse("c1798952-dda0-4c87-bb10-b92a4286c3c3"), Type = TextBlockType.Text, Text = "You use a performer’s cold reading techniques, aura reading, and other tricks to discover your foe’s strengths and weaknesses. The GM rolls a secret Occultism check for you against the Deception or Stealth DC (whichever is higher) of an enemy of your choice who is engaged in combat and isn’t concealed from you, hidden from you, or undetected by you. The GM might apply a penalty for the distance between you and the enemy. The enemy is then temporarily immune to your Combat Reading for 1 day." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("519477ba-2b34-49e5-88cb-a738df1c7a2b"),
                CriticalSuccess = "The GM chooses and tells you two of the following pieces of information about the enemy: which of the enemy’s weaknesses is highest, which of the enemy’s saving throws has the lowest modifier, one immunity the enemy has, or which of the enemy’s resistances is highest. In the event of a tie, the GM should pick one at random.",
                Success = "The GM chooses one piece of information from the above list to tell you about the enemy.",
                
                CriticalFailure = "The GM gives you false information (the GM makes up the information).", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bdb79fb4-8244-4f0f-b2a4-30dfbda0cfab"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
