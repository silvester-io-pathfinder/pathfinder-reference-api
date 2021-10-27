using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ActionTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances
{
    public class PointOut : Template
    {
        public static readonly Guid ID = Guid.Parse("187ebb2b-c829-4d40-81dd-414a48ea766e");

        protected override Models.Entities.Action GetAction()
        {
            return new Models.Entities.Action
            {
                Id = ID,
                Name = "Point Out",
                Requirements = "A creature is undetected by one or more of your allies but isn’t undetected by you.",
                ActionTypeId = OneAction.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("e9c5de9d-eef6-46d4-ae1b-0dee8958af0c"), Text = "You indicate a creature that you can see to one or more allies, gesturing in a direction and describing the distance verbally. That creature is hidden to your allies, rather than undetected (page 466). This works only for allies who can see you and are in a position where they could potentially detect the target. If your allies can’t hear or understand you, they must succeed at a Perception check against the creature’s Stealth DC or they misunderstand and believe the target is in a different location." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Auditory.ID;
            yield return Manipulate.ID;
            yield return Visual.ID;
        }
    }
}
