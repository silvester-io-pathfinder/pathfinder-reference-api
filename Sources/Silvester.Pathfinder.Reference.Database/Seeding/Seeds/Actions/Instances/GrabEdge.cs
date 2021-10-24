using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ActionTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances
{
    public class GrabEdge : Template
    {
        public static readonly Guid ID = Guid.Parse("90d27bd9-31ed-46f4-a174-467e165ed1b9");

        protected override Models.Action GetAction()
        {
            return new Models.Action
            {
                Id = ID,
                Name = "Grab Edge",
                Trigger = "You fall from or past an edge or handhold.",
                Requirements = "Your hands are not tied behind your back or otherwise restrained.",
                ActionTypeId = Reaction.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("135aadcd-6eaf-4401-909d-de2414c5ccbc"), Text = "When you fall off or past an edge or other handhold, you can try to grab it, potentially stopping your fall. You must succeed at a Reflex save, usually at the Climb DC. If you grab the edge or handhold, you can then Climb up using Athletics." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Manipulate.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("f5c01f9a-15de-47c0-8f65-470f0c4442dd"),
                CriticalSuccess = "You grab the edge or handhold, whether or not you have a hand free, typically by using a suitable held item to catch yourself (catching a battle axe on a ledge, for example). You still take damage from the distance fallen so far, but you treat the fall as though it were 30 feet shorter.",
                Success = "If you have at least one hand free, you grab the edge or handhold, stopping your fall. You still take damage from the distance fallen so far, but you treat the fall as though it were 20 feet shorter. If you have no hands free, you continue to fall as if you had failed the check.",
                CriticalFailure = "You continue to fall, and if you’ve fallen 20 feet or more before you use this reaction, you take 10 bludgeoning damage from the impact for every 20 feet fallen."
            };
        }
    }
}
