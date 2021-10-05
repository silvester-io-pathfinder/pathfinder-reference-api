using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Planes.Instances
{
    public class PositiveEnergyPlane : Template
    {
        public static readonly Guid ID = Guid.Parse("b31acddd-b42e-4014-95cf-0e9ca41c73d3");

        protected override Plane GetPlane()
        {
            return new Plane 
            { 
                Id = ID, 
                CategoryId = PlaneCategories.Instances.InnerSpherePlane.ID, 
                AlignmentId = Alignments.Instances.TrueNeutral.ID, 
                Name = "Positive Energy Plane",
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Positive.ID;
            yield return SubjectiveGravity.ID;
            yield return Unbounded.ID;
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d2c33942-cb3c-4c6f-b692-00d80338250c"), Type = TextBlockType.Text, Text = "Known as Creation’s Forge, the Positive Energy Plane is at once the source of life-sustaining positive energy, the origin of all pre-incarnate mortal souls, and paradoxically the most innately hostile of all of the planes. While positive energy is deadly to undead and beneficial to living beings, such is the intensity of the plane that unmitigated exposure ultimately incinerates any extraplanar beings without sufficient magical protection. The most apt comparison for the plane’s interior is that of the heart of a burning star, and indeed the stars of the Material Plane each house natural portals to the Positive Energy Plane within their glowing, potent cores to foster the movement of pre-incarnate souls in their first steps in the great cycle of life and death." };
            yield return new TextBlock { Id = Guid.Parse("93a4239a-b45d-4d02-a2d5-ec9f053508a8"), Type = TextBlockType.Text, Text = "Brilliant and blinding, the plane’s interior is sparsely populated, and the resident phoenix-kin jyoti are intensely xenophobic. Dwelling in glimmering, radiant crystalline cities such as Arudrellisiir, they view themselves as gardeners and guardians of souls spawned from their realm’s burning quintessence. Intensely distrustful of gods and their servitors, jyoti can nonetheless be bargained with, and they have frequently taken into their custodianship any number of artifacts and imprisoned beings considered too dangerous to house on any other plane." };
        }
    }
}
