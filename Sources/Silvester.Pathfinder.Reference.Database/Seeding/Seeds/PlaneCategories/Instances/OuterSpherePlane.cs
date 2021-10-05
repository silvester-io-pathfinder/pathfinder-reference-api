using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlaneCategories.Instances
{
    public class OuterSpherePlane : Template
    {
        public static readonly Guid ID = Guid.Parse("c64c6e93-aa40-4010-8fbc-592c1f0e017a");

        protected override PlaneCategory GetPlaneCategory()
        {
            return new PlaneCategory 
            { 
                Id = ID, 
                Name = "Outer Sphere Plane",
                Description = "The planes of the Outer Sphere are the manifest realms of alignment: chaos, evil, good, law, neutrality, and their admixtures, populated by celestials, fiends, monitors, and others who promote these moral concepts. These planes are the backdrop upon which the mortal afterlife reaches its apparent conclusion, and the end destination of the River of Souls. The Outer Planes are regions of stability adrift in the raw, chaotic quintessence of the primordial Maelstrom, its tides forever gnawing at their edges even as mortal souls sustain them. The Abyss manifests as cracks in the Outer Sphere’s fabric, while rising from the metropolitan Axis is the Boneyard’s spire, the location where mortal souls are judged and then sent to their final destinations, be they reward, suffering, or oblivion. The Outer Planes are places of majesty, wonder, terror, and danger outstripping anything mortal adventurers might encounter anywhere else." 
            };
        }
    }
}
