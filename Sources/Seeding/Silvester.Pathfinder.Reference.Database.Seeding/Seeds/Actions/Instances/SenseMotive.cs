using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ActionTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances
{
    public class SenseMotive : Template
    {
        public static readonly Guid ID = Guid.Parse("f715d730-9ad4-4922-b893-cda88fe25ea4");

        protected override Models.Entities.Action GetAction()
        {
            return new Models.Entities.Action
            {
                Id = ID,
                Name = "Sense Motive",
                ActionTypeId = OneAction.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("65547cff-999a-493d-a6c1-4f56d3f0662a"), Text = "You try to tell whether a creature’s behavior is abnormal. Choose one creature, and assess it for odd body language, signs of nervousness, and other indicators that it might be trying to deceive someone. The GM attempts a single secret Perception check for you and compares the result to the Deception DC of the creature, the DC of a spell affecting the creature’s mental state, or another appropriate DC determined by the GM. You typically can’t try to Sense the Motive of the same creature again until the situation changes significantly." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Concentrate.ID;
            yield return Secret.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("e83cff43-911b-41f0-a5d3-e67bed0ca36b"),
                CriticalSuccess = "You determine the creature’s true intentions and get a solid idea of any mental magic affecting it.",
                Success = "You can tell whether the creature is behaving normally, but you don’t know its exact intentions or what magic might be affecting it.",
                Failure = "You detect what a deceptive creature wants you to believe. If they’re not being deceptive, you believe they’re behaving normally.",
                CriticalFailure = "You get a false sense of the creature’s intentions."
            };
        }
    }
}
