using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CourageousOpportunity : Template
    {
        public static readonly Guid ID = Guid.Parse("410dabf4-db88-4aa8-ae59-dc05fc7e10d7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Courageous Opportunity",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature within your reach uses an auditory effect, manipulate action, or move action; makes a ranged attack; or leaves a square during its move action.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1fb5d6c1-fd75-4a39-8b00-79d13bf3a79d"), Type = TextBlockType.Text, Text = "You bellow a ferocious call to arms, inspiring yourself to lash out at a foe. Make a melee (action: Strike) against the triggering creature. If the attack is a critical hit and the trigger was a (trait: manipulate) action, the action is disrupted." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("f122952c-889e-4bd6-b29a-9f281a47d7a7"), Muses.Instances.Warrior.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("06c3b139-b1fc-4bcc-a0c6-58055ee31512"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
