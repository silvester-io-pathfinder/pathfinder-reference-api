using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Planes.Instances
{
    public class AstralPlane : Template
    {
        public static readonly Guid ID = Guid.Parse("2e98856d-d10d-46c9-8d7a-fe12e6581733");

        protected override Plane GetPlane()
        {
            return new Plane 
            { 
                Id = ID, 
                CategoryId = PlaneCategories.Instances.TransitivePlane.ID, 
                AlignmentId = Alignments.Instances.TrueNeutral.ID, 
                Name = "Astral Plane"
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return SubjectiveGravity.ID;
            yield return Timeless.ID;
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("65b17ccb-f31f-4f32-972d-b743919576c2"), Type = TextBlockType.Text, Text = "The Silver Sea surrounds the planes of the Inner Sphere, separating them from those of the Outer Sphere. The Astral Plane provides the backdrop against which the River of Souls flows from the Material Plane, ushering departed spirits toward final judgment. Far from an empty void, the Astral’s silver substance churns with currents and storms from the metaphysical heat of the Plane of Fire, and where it touches the chaos of the Maelstrom, the resulting eddies interact with the memories of the dead to produce fleeting simulacra and even demiplanes." };
            yield return new TextBlock { Id = Guid.Parse("90524d39-75fb-4258-bd1f-f17acdd1df2c"), Type = TextBlockType.Text, Text = "The River of Souls draws the attention of soul-hunting daemons and opportunistic night hags like sharks drawn to the scent of blood. Led by psychopomps, a cross section of nearly every type of celestial and monitor in existence, along with some fiends, defends the proper flow of souls against such predators. Running opposite the River of Souls is the flow of raw, unaligned quintessence spun off from the so-called Antipode, channeled by aeons back toward the Positive Energy Plane." };
            yield return new TextBlock { Id = Guid.Parse("c0d9c043-d030-4aa4-b3e8-cec463406e62"), Type = TextBlockType.Text, Text = "Travelers within the Astral find the plane untouched by the passage of time, a property exploited by many mortals fearing old age. Time, however, is not easily escaped, and upon exiting the Astral Plane, a creature finds this debt catching up to them, potentially aging to dust in moments." };
        }
    }
}
