using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Planes.Instances
{
    public class Maelstrom : Template
    {
        public static readonly Guid ID = Guid.Parse("235e010f-bfb6-40f0-a65f-628f2ea721bf");

        protected override Plane GetPlane()
        {
            return new Plane 
            { 
                Id = ID, 
                CategoryId = PlaneCategories.Instances.OuterSpherePlane.ID, 
                AlignmentId = Alignments.Instances.ChaoticNeutral.ID, 
                Name = "Maelstrom", 
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Metamorphic.ID;
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("55e6d888-5aba-41d9-bb34-4561a8d246b8"), Type = TextBlockType.Text, Text = "The Maelstrom, infinite and ancient, spawned the other Outer Planes in cosmological prehistory and surrounds them like a vast metaphorical—and at times literal—ocean of raw, chaotic quintessence. Where the Maelstrom borders these other planes, its structure takes on their characteristics, albeit in an unpredictable, chaotic fashion. Beyond these so-called Borderlands, however, the Maelstrom reverts to its true nature, the Cerulean Void: a trackless, liquid infinity devoid of stability and permanence where serpentine proteans create and destroy with profound frivolity. The proteans are paradoxically organized into discrete choruses, each with its own philosophy and goals in service to the Maelstrom. Swirling with oddities and wild magic, bereft of laws and structure, the Maelstrom also serves as a conduit between the other Outer Planes utilized by armies of extraplanar beings, hordes of demons spilling forth from the Abyss, and the innumerable protean choruses seeking to return the rest of the planes to the true freedom of the chaos from which they emerged. Sufficiently powerful magic can stabilize the chaos for a time, allowing for the creation of demiplanes and stable islands. The massive planar trade city of Galisemni is most prominent among these, drifting through the chaos." };
        }
    }
}
