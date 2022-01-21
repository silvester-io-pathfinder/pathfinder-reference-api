using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class AttackOfOpportunity : Template
    {
        public static readonly Guid ID = Guid.Parse("5fd106c3-5ef7-4586-a41f-96b179aad894");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Attack of Opportunity",
                Trigger = "A creature within the monster's reach uses a manipulate action or a move action, makes a ranged attack, or leaves a square during a move action it's using.",
                ActionTypeId = ActionTypes.Instances.Reaction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("41c3d47d-a63d-426b-af21-e1ba4851dd52"), Text = " The monster attempts a melee Strike against the triggering creature. If the attack is a critical hit and the trigger was a manipulate action, the monster disrupts that action. This Strike doesn't count toward the monster's multiple attack penalty, and its multiple attack penalty doesn't apply to this Strike." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4a9c9b2d-26a5-49ee-a6ba-ecb03c44d349"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 342
            };
        }
    }
}
