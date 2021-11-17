using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlaneCategories.Instances
{
    public class InnerSpherePlane : Template
    {
        public static readonly Guid ID = Guid.Parse("3bbe8661-ea39-4b26-8723-eb04b151062f");

        protected override PlaneCategory GetPlaneCategory()
        {
            return new PlaneCategory 
            { 
                Id = ID, 
                Name = "Inner Sphere Plane", 
                Description = "The planes of the Inner Sphere form the heart of the cosmos. They are the home of mortal life, the focus of divine attention, the source of mortal souls, and the origin point of the great cycle of quintessence that fuels the motions and stability of reality itself. Arranged in a nested series of shells, like layers of an onion, the planes of the Inner Sphere include, from outer to inner: the Elemental Planes of Fire, Earth, Water, and Air; the universe of the Material Plane; and at the very core of this cosmological ensemble, the raw forces of creation and destruction of the Positive and Negative Energy Planes." 
            };
        }
    }
}
