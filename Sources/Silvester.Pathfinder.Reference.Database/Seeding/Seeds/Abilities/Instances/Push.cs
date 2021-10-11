using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class Push : Template
    {
        public static readonly Guid ID = Guid.Parse("0305718e-aff3-4edc-a260-75f9e5970d7c");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Push",
                Requirements = "The monster's last action was a success with a Strike that lists Push in its damage entry",
                ActionTypeId = ActionTypes.Instances.OneAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("2949c673-ebb7-4905-ac4a-2197eb98d42d"), Text = "The monster automatically knocks the target away from the monster. Unless otherwise noted in the ability description, the creature is pushed 5 feet. If the attack was a critical hit, this distance is doubled." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1be112a7-fd67-4169-8812-a217f0c35e3e"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 343
            };
        }
    }
}
