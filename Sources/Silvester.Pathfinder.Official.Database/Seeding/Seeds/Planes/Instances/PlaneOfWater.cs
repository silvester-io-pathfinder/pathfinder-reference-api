using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Planes.Instances
{
    public class PlaneOfWater : Template
    {
        public static readonly Guid ID = Guid.Parse("f4048c73-6fb0-496c-9e7b-dff087bea6ef");

        protected override Plane GetPlane()
        {
            return new Plane 
            { 
                Id = ID, 
                CategoryId = PlaneCategories.Instances.InnerSpherePlane.ID, 
                AlignmentId = Alignments.Instances.TrueNeutral.ID, 
                Name = "Plane of Water",
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return SubjectiveGravity.ID;
            yield return Water.ID;
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a32407b1-37b3-4309-bd75-8bc7a1b061b4"), Type = TextBlockType.Text, Text = "Beyond the skies of the Plane of Air, the clouds grow darker and condense into the vast, spherical, liquid shell of the Plane of Water. Its nearly limitless stretches of saline, fresh, and brackish seas teem with all manner of oceanic life, lit by light from the border with the Plane of Air and descending into black, benthic depths where it borders the Plane of Earth. While the plane is perfectly amenable to water-breathing creatures, air-breathing travelers must provide their own supply of air or magical means to breathe. Bubbles of breathable atmosphere are relatively rare and securely guarded, anchored over places of trade and commerce with outsiders, such as the great city of Vialesk, founded by immigrant undines. The plane’s oceans, dotted by vast forests of kelp, magical currents, and strange phenomena, play host to empires of merfolk, predatory and expansionist sea devils, and the holdings of the plane’s great brine dragons." };
            yield return new TextBlock { Id = Guid.Parse("6433b16d-1aff-45c5-9ffe-db7f0182de47"), Type = TextBlockType.Text, Text = "While marids once claimed nearly absolute dominion over the plane of their origin, their empire long ago fell into deterioration and disunity. Their ravaged cities sank into the depths, and their present-day holdings remain a shadow of their former grandeur. Kelizandri the Brackish Emperor, the evil elemental lord of water and cause of their ruin, rules the dark, saline depths, feasting on all rivals and hoarding the vast, stolen wealth of the fallen marid cities. Unlike other subjective gravity planes, on the Plane of Water, a creature moves based on its swim Speed and must use actions to Swim if it doesn’t have one." };
        }
    }
}
