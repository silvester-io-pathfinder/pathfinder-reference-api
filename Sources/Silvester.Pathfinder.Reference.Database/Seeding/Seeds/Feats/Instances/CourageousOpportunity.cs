using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CourageousOpportunity : Template
    {
        public static readonly Guid ID = Guid.Parse("2d5aecc7-e2e5-47b3-9f90-8b251e0a1d1f");

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
            yield return new TextBlock { Id = Guid.Parse("2aa9560a-1855-4aba-a7dd-89ec9e76106d"), Type = TextBlockType.Text, Text = "You bellow a ferocious call to arms, inspiring yourself to lash out at a foe. Make a melee (action: Strike) against the triggering creature. If the attack is a critical hit and the trigger was a (trait: manipulate) action, the action is disrupted." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("a94323ad-d276-4c9b-8e3b-5d3f0218cd1b"), Muses.Instances.Warrior.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("06f4e505-e8e9-422b-a410-fdc9c0840b90"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
