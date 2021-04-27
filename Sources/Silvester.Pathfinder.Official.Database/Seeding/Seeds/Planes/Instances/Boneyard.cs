using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Planes.Instances
{
    public class Boneyard : AbstractPlaneTemplate
    {
        public static readonly Guid ID = Guid.Parse("7c34baea-48a6-4a49-8b15-8781a5c1ab47");

        protected override Plane GetPlane()
        {
            return new Plane 
            { 
                Id = ID, 
                CategoryId = PlaneCategories.Instances.OuterSpherePlane.ID, 
                AlignmentId = Alignments.Instances.TrueNeutral.ID, 
                Name = "Boneyard", 
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Timeless.ID;
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("40b02cb7-ca2c-4d87-a81a-a7a1fe923819"), Type = TextBlockType.Text, Text = "The Boneyard spans an impossibly tall and ever-growing spire of gleaming quintessence that rises up into the silver void of the Astral Plane. As the destination of the River of Souls, the Boneyard is where the souls of the mortal dead arrive for judgment and for Pharasma and her psychopomp servitors to direct them to their respective afterlives. Pharasma’s domain is separated into eight courts, each corresponding to one of the other planes of the Outer Sphere and collecting the souls due to that plane. Not every soul goes unchallenged, and proxies of gods and planes argue and debate over souls, with final arbitration conducted by Pharasma herself." };
            yield return new TextBlock { Id = Guid.Parse("f6441afa-f53b-4d65-938d-e855f0b85314"), Type = TextBlockType.Text, Text = "While Pharasma rules absolutely within the Boneyard, she is not the only divinity there. The demigod psychopomp ushers dwell within the plane in service to her, and the deity Achaekek dwells below at the spire’s root. Looming high above as a skull-faced moon waits Groetus, the god of the end times, his orbit slowly decaying in minuscule iterations supposedly counting down to the last days of the cosmos." };
            yield return new TextBlock { Id = Guid.Parse("98e6c296-c6c0-4862-812f-c0bcf5b98481"), Type = TextBlockType.Text, Text = "Pharasma’s courts and the surrounding Graveyard of Souls are not the only features atop the spire. Beyond the graveyard, the Spirelands manifest environments much like those of the varied Material Plane worlds, filled with the souls of neutral petitioners who have nowhere else to go as they are unclaimed by any gods and unaligned with any particular ethos." };
        }
    }
}
