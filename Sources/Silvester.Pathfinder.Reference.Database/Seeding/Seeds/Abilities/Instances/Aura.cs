using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class Aura : Template
    {
        public static readonly Guid ID = Guid.Parse("14e6d770-90b2-47a5-bf48-d4985077aa5c");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Aura",
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("376f2214-3778-4c5d-8022-6a5a15d66a2b"), Text = "A monster's aura automatically affects everything within a specified emanation around that monster. The monster doesn't need to spend actions on the aura; rather, the aura's effects are applied at specific times, such as when a creature ends its turn in the aura or when creatures enter the aura." };
            yield return new TextBlock { Id = Guid.Parse("14179eae-fcb8-401d-83f9-1d953b7ac2a8"), Text = "If an aura does nothing but deal damage, its entry lists only the radius, damage, and saving throw. Such auras deal this damage to a creature when the creature enters the aura and when a creature starts its turn in the aura. A creature can take damage from the aura only once per round." };
            yield return new TextBlock { Id = Guid.Parse("4dec1985-077f-4a7c-8043-dd54bd9c5061"), Text = "The GM might determine that a monster's aura doesn't affect its own allies. For example, a creature might be immune to a monster's frightful presence if they have been around each other for a long time." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("91b85327-5bec-4faf-b851-254197ab88ac"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 342
            };
        }
    }
}
