using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Planes.Instances
{
    public class PlaneOfFire : AbstractPlaneTemplate
    {
        public static readonly Guid ID = Guid.Parse("d1670c72-3c58-4e8a-8c36-6dd1d944383d");

        protected override Plane GetPlane()
        {
            return new Plane 
            { 
                Id = ID, 
                CategoryId = PlaneCategories.Instances.InnerSpherePlane.ID, 
                AlignmentId = Alignments.Instances.TrueNeutral.ID, 
                Name = "Plane of Fire",
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Fire.ID;
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("5884b0a0-2e07-4d95-8223-24ee976ca9f9"), Type = TextBlockType.Text, Text = "Like a great, gleaming ball of flame situated at the heart of the Astral Plane, the Plane of Fire is the outermost plane of the Inner Sphere. A perpetual ocean of fire with skies of smoke, storms of raining cinders, and lakes and rivers of magma flowing along its border with the Elemental Plane of Earth, the plane is incredibly hostile to those unprepared for its natural hazards. Yet it houses one of the most well-known and traversed cities in all the planes: the City of Brass, capital of the Dominion of Flame. Floating above a sea of fire upon a great hemisphere of magical brass, the City of Brass is a monument both to efreet cosmopolitan grandeur and tyranny, the latter embodied by the grand sultana of the efreet. Outside of the mercantile districts and the palaces and temples of the fire genies, the city houses a vast enslaved underclass of salamanders and others, including creatures from other planes." };
            yield return new TextBlock { Id = Guid.Parse("8315e358-6c94-43a2-abc3-3dcdb0ca2fe2"), Type = TextBlockType.Text, Text = "The efreeti domain is not absolute, and elsewhere in the plane are nations of fire mephits and the remains of an ancient azer empire. While they don’t form any cohesive, organized nations, the plane’s fire elementals are ruled over by the plane’s most powerful entity, Ymeri the Queen of the Inferno, the evil elemental lord of fire whose reign has gone unquestioned since the imprisonment of her good-aligned rival Atreia eons ago." };
        }
    }
}
