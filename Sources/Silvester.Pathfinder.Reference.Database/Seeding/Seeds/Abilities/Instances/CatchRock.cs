using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class CatchRock : Template
    {
        public static readonly Guid ID = Guid.Parse("a12373de-5426-429f-a2a9-cc2b9a1ce038");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Catch Rock",
                Requirements = "The monster must have a free hand but can Release anything it�s holding as part of this reaction.",
                Trigger = "The monster is targeted with a thrown rock Strike or a rock would fall on the monster.",
                ActionTypeId = ActionTypes.Instances.Reaction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("c47a6eb3-cd0f-441c-90f5-59c2fd6e2494"), Text = "The monster gains a +4 circumstance bonus to its AC against the triggering attack or to any defense against the falling rock. If the attack misses or the monster successfully defends against the falling rock, the monster catches the rock, takes no damage, and is now holding the rock." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9b70e6c9-fbb1-4c00-96e3-0e7e7ea665a0"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 342
            };
        }
    }
}
