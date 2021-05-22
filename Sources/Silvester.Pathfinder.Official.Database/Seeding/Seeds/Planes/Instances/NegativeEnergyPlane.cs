using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Planes.Instances
{
    public class NegativeEnergyPlane : Template
    {
        public static readonly Guid ID = Guid.Parse("1a0e31c5-8271-458c-a941-d1a9a5a60d51");

        protected override Plane GetPlane()
        {
            return new Plane 
            { 
                Id = ID, 
                CategoryId = PlaneCategories.Instances.InnerSpherePlane.ID, 
                AlignmentId = Alignments.Instances.TrueNeutral.ID, 
                Name = "Negative Energy Plane",
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Negative.ID;
            yield return SubjectiveGravity.ID;
            yield return Unbounded.ID;
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d8f8629b-8169-4e23-b8ec-4a4001fb7fbf"), Type = TextBlockType.Text, Text = "The vast void of the Negative Energy Plane is a merciless, lightless expanse of manifest destruction and nothingness. Sapping and consuming the life force of any living creature exposed to its energies, it corrodes and disintegrates material objects to rubble, then dust, and then nothing at all. Yet the Void contains its own form of anti-life. At their densest concentration, the plane’s energies aggregate into bizarre, black crystalline snowflake structures, and these irregularities spontaneously generate the plane’s resident sceaduinars. Dwelling in beautiful, deadly cities drifting in the vacuous darkness, these so-called void raptors are incapable of true creation and blame this flaw on some ancient betrayal by their rivals on the Positive Energy Plane. Sceaduinars react violently not only toward creatures sustained by positive energy, but also toward undead, whom they view as unnatural parasites unworthy of their plane’s energies." };
            yield return new TextBlock { Id = Guid.Parse("0365a377-122b-450e-b196-a68c61999b13"), Type = TextBlockType.Text, Text = "The black depths also swarm with undead, creatures doomed to a mockery of life by the interaction of their souls with the plane’s entropic energy. Yet for all the horrors posed by the plane’s environment, inhabitants, and its undead victims, its depths nevertheless hide rare refuges for planar travelers. Malikar’s Keep offers shelter, for a price, to those willing to bargain with its titular lich master, while elsewhere the depths hide entire lost worlds such as Fallen Duromak, and deadly mysteries like the planet-sized, undead-entrapping glass sphere, Eternity’s Doorstep." };
        }
    }
}
