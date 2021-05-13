using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Planes.Instances
{
    public class Abyss : Template
    {
        public static readonly Guid ID = Guid.Parse("10be56f4-5519-4cb6-8038-83dda6b0d00a");

        protected override Plane GetPlane()
        {
            return new Plane 
            { 
                Id = ID, 
                CategoryId = PlaneCategories.Instances.OuterSpherePlane.ID, 
                AlignmentId = Alignments.Instances.ChaoticEvil.ID, 
                Name = "Abyss", 
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("02b3211d-7549-4d13-aaaf-44f6f16d6c40"), Type = TextBlockType.Text, Text = "Like a corrosive rot in the roots of the Outer Sphere, or an antithetical, rival reality run aground into the Maelstrom at the dawn of time, the Abyss is a place of horror and destruction fed by mortal sin. Each of its innumerable regions is a unique iteration of chaos and evil, each with its own terrible and twisted environment, with one driving maxim: the strong survive, while the weak suffer and are destroyed. Ruled by demons, and before them by the alien, nightmarish qlippoth, the Abyss and its native beings seek only to ravage and destroy. While demons routinely rampage out into other planes when the Abyss manifests a great planar rift, the denizens of the Abyss are fractured and self-destructive. Demon lords such as Dagon, Pazuzu, and Zura, and even gods including the ascended demon lord Lamashtu, the Mother of Monsters, fight for dominion over the Abyss as much or more than they threaten the other planes. Though dangerous, not every realm of the Abyss is immediately hostile to the prepared traveler. Shamira’s city of Alushinyrra in the Midnight Isles and Abraxas’s library-city of Diovengia in the realm of Pleroma are each welcoming in their own dark ways. Even those who survive a journey through the Abyss, however, inevitably must resist being deeply corrupted by the experience." };
        }
    }
}
