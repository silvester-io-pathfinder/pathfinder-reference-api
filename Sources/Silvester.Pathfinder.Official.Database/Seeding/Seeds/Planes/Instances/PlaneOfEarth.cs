using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Planes.Instances
{
    public class PlaneOfEarth : AbstractPlaneTemplate
    {
        public static readonly Guid ID = Guid.Parse("71064085-85ef-4986-b34c-c270b398749a");

        protected override Plane GetPlane()
        {
            return new Plane 
            { 
                Id = ID, 
                CategoryId = PlaneCategories.Instances.InnerSpherePlane.ID, 
                AlignmentId = Alignments.Instances.TrueNeutral.ID, 
                Name = "Plane of Earth",
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Earth.ID;
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("061e73d5-01fd-4f46-81d2-ea65d8cbafd2"), Type = TextBlockType.Text, Text = "A great and rocky shell situated between the Plane of Fire and Plane of Water, the Eternal Delve hosts a unique and varied ecology of creatures at home in its rocky depths. Far from an endless, solid expanse, the Plane of Earth is riddled with great caverns and cave systems, excavated artificial vaults, vast crystalline geodes, and underground oceans and springs of magma where it borders its neighboring planes. Housing untold riches in gemstones and veins of precious metals, the Plane of Earth is an attractive setting for planar travelers seeking wealth and willing to risk danger and the wrath of elementals, shaitans, and other inhabitants who resent the plunder of their home." };
            yield return new TextBlock { Id = Guid.Parse("37b3c2a7-ec42-47d2-9753-cc30931fdbd9"), Type = TextBlockType.Text, Text = "While elementals have little organized society, the shaitan genies’ Peerless Empire rules much of the plane from its capital, the Opaline Vault—a rainbow-lit city within a 30-mile-wide geode cavern. The shaitans have long been at war with the efreet in the neighboring Plane of Fire, and while the earth genies are less prone to slavery than their rivals, the shaitans brook little dissent, and their rule can be harsh. They are downright welcoming, however, compared to Ayrzul the Fossilized King, the evil elemental lord of earth who rules a great expanse of rock from his radiation-poisoned domain, the Blistering Labyrinth." };
        }
    }
}
