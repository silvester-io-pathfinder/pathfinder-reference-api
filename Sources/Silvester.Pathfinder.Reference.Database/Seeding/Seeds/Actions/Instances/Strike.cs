using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ActionTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances
{
    public class Strike : Template
    {
        public static readonly Guid ID = Guid.Parse("577e96ba-5bf3-46e7-9f4b-eb5b71546bfd");

        protected override Models.Action GetAction()
        {
            return new Models.Action
            {
                Id = ID,
                Name = "Strike",
                ActionTypeId = OneAction.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("36548991-704d-4a82-a2c4-0622eb57f728"), Text = "You attack with a weapon you’re wielding or with an unarmed attack, targeting one creature within your reach (for a melee attack) or within range (for a ranged attack). Roll the attack roll for the weapon or unarmed attack you are using, and compare the result to the target creature’s AC to determine the effect. See Attack Rolls on page 446 and Damage on page 450 for details on calculating your attack and damage rolls." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Attack.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("9dab564c-885e-492a-a52e-af745342c53d"),
                CriticalSuccess = "As success, but you deal double damage (page 451).",
                Success = "You deal damage according to the weapon or unarmed attack, including any modifiers, bonuses, and penalties you have to damage."
            };
        }
    }
}
