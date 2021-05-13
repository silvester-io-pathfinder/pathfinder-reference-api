using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.ActionTypes.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances
{
    public class Seek : Template
    {
        public static readonly Guid ID = Guid.Parse("ada1f776-2e98-4e7d-96e1-2166837fab6b");

        protected override Models.Action GetAction()
        {
            return new Models.Action
            {
                Id = ID,
                Name = "Seek",
                ActionTypeId = OneAction.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("e2a4876a-0d17-4bca-9874-8a0f708e39c3"), Text = "You scan an area for signs of creatures or objects. If you’re looking for creatures, choose an area you’re scanning. If precision is necessary, the GM can have you select a 30-foot cone or a 15-foot burst within line of sight. You might take a penalty if you choose an area that’s far away." };
            yield return new TextBlock { Id = Guid.Parse("722290ac-d0fa-43f9-9406-291d071f0fc9"), Text = "If you’re using Seek to search for objects (including secret doors and hazards), you search up to a 10-foot square adjacent to you. The GM might determine you need to Seek as an activity, taking more actions or even minutes or hours if you’re searching a particularly cluttered area." };
            yield return new TextBlock { Id = Guid.Parse("d666a8f0-877c-4b2d-8bac-7c3cbe35b525"), Text = "The GM attempts a single secret Perception check for you and compares the result to the Stealth DCs of any undetected or hidden creatures in the area or the DC to detect each object in the area (as determined by the GM or by someone Concealing the Object). A creature you detect might remain hidden, rather than becoming observed, if you’re using an imprecise sense or if an effect (such as invisibility) prevents the subject from being observed." };
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
                Id = Guid.Parse("c6c59505-6b03-46fe-b154-1c303d7176e4"),
                CriticalSuccess = "If you were searching for creatures, any undetected or hidden creature you critically succeeded against becomes observed by you. If you were searching for an object, you learn its location.",
                Success = "If you were searching for creatures, any undetected creature you succeeded against becomes hidden from you instead of undetected, and any hidden creature you succeeded against becomes observed by you. If you were searching for an object, you learn its location or get a clue to its whereabouts, as determined by the GM.",
            };
        }
    }
}
