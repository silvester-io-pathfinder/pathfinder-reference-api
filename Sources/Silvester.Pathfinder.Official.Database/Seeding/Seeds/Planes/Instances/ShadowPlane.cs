using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Planes.Instances
{
    public class ShadowPlane : AbstractPlaneTemplate
    {
        public static readonly Guid ID = Guid.Parse("3e4b22a2-a4bd-42cc-b27f-a381758a4c11");

        protected override Plane GetPlane()
        {
            return new Plane 
            { 
                Id = ID, 
                CategoryId = PlaneCategories.Instances.TransitivePlane.ID, 
                AlignmentId = Alignments.Instances.TrueNeutral.ID, 
                Name = "Shadow Plane",
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Shadow.ID;
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("82710ca9-8352-46f0-be9b-8d57dde2b1a1"), Type = TextBlockType.Text, Text = "A murky, distorted, and imperfect mirror of the Material Plane, the Shadow Plane overlaps the Material Plane and serves as a buffer or conduit between it and the Negative Energy Plane. The Shadow Plane exists in a state of perpetually dim half-light, the landscape containing similar features to the overlapping Material Plane, but in warped or twisted fashions. Cities on the Material Plane might exist on the Shadow Plane, sometimes in ruins and sometimes as terrible, frightening replicas. The darkness also holds points of beauty and relative safety, such as the great city of Shadow Absalom. The bleak doppelganger of Golarion’s own Absalom hosts cross-planar trade facilitated by a permanent, one-way portal out of the gloom." };
            yield return new TextBlock { Id = Guid.Parse("bb432725-30fa-4cd5-8a85-d9814a0e2531"), Type = TextBlockType.Text, Text = "The Shadow Plane is populated by dark, altered versions of creatures from the Material Plane, many of them immigrants that have adapted to the shadow after being trapped in the realm for generations. The shadow natives known as kayals—also known as fetchlings—were originally humans before thousands of years of exposure to the Shadow Plane and breeding with strange beings forever altered them. Velstracs, who long ago fled from Hell, have since adopted the Shadow Plane as their home, spreading their horrific message of perfection through mutilation in service to their victim and patron, the god Zon-Kuthon. In contrast, d’ziriaks originated within the Shadow Plane itself, as have the fearsome umbral dragons ruling self-crafted fiefdoms within the shadows. Greatest of these is Argrinyxia, who rules over Shadow Absalom." };
        }
    }
}
