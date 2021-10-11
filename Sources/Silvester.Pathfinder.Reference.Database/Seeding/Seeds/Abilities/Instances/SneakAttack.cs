using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class SneakAttack : Template
    {
        public static readonly Guid ID = Guid.Parse("d41e203b-d833-4635-957e-854720aec20f");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Sneak Attack",
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("994d48dd-a366-4d35-9eaa-91337ff1e8f0"), Text = "When the monster Strikes a creature that has the flat-footed condition with an agile or finesse melee weapon, an agile or finesse unarmed attack, or a ranged weapon attack, it also deals the listed precision damage. For a ranged attack with a thrown weapon, that weapon must also be an agile or finesse weapon." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("da2fca54-e27d-4eae-895d-5468f750f144"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 344
            };
        }
    }
}
