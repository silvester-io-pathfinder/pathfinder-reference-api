using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlaneCategories.Instances
{
    public class TransitivePlane : Template
    {
        public static readonly Guid ID = Guid.Parse("a1485da2-c025-45cd-bc59-f08fe12b7d5b");

        protected override PlaneCategory GetPlaneCategory()
        {
            return new PlaneCategory 
            { 
                Id = ID, 
                Name = "Transitive Plane",
                Description = "At a minimum, each Transitive Plane coexists with one or more other planes, a relationship oversimplified by stating that Transitive Planes are just used to get from one plane to another. The mists of the Ethereal Plane overlap the planes of the Inner Sphere, while the Astral Plane borders every other plane in existence like the backstage of the cosmos. Bright and dark mirrors of the Material Plane, the First World and Shadow Plane overlap the mortal world, albeit often in bizarre ways such that a short distance in one might be a vast gulf in the other. The daring, wise, or desperate can utilize these planes to bypass barriers in the Material Plane or rapidly cross vast distances through much swifter travel." 
            };
        }
    }
}
