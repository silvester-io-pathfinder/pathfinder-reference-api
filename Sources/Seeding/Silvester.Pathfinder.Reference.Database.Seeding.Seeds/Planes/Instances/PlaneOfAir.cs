using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Planes.Instances
{
    public class PlaneOfAir : Template
    {
        public static readonly Guid ID = Guid.Parse("b191ffc0-7a9a-4285-b758-7542bef75a85");

        protected override Plane GetPlane()
        {
            return new Plane 
            { 
                Id = ID, 
                CategoryId = PlaneCategories.Instances.InnerSpherePlane.ID, 
                AlignmentId = Alignments.Instances.TrueNeutral.ID, 
                Name = "Plane of Air",
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Air.ID;
            yield return SubjectiveGravity.ID;
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c74d689c-e21d-4855-b316-87d2c7dcefc0"), Type = TextBlockType.Text, Text = "The Plane of Air, innermost of the Elemental Planes, is a vast realm of wind, storms, and skies. Illuminated by great artificial globes of flame and distant starlight from the material universe, the plane is populated by air elementals, dragons, mephits, and a great empire of djinn. Though mostly clouds and empty skies, the plane is not entirely bereft of solid ground, including rock and ice created by the residents or dragged into their realm from the distant Plane of Earth or neighboring Plane of Water, and bizarre, drifting spheres of brass and iron. While the former are aggressively fought over, most housing the cities of the vast djinn empire, the latter are almost entirely abandoned and shunned by the plane's inhabitants, who believe them cursed, entrapping forgotten, ancient enemies who once ravaged the plane." };
            yield return new TextBlock { Id = Guid.Parse("605a13e6-09b2-47ad-aa51-15d52e9d22f7"), Type = TextBlockType.Text, Text = "The djinn rule from their shining capital city of Armun Kelisk, built atop a series of seven floating islands. Their vast trade network crisscrosses the skies and ventures to other planes, kept aloft by natural and magical flight, including great airships that allow visitors to quickly and safely traverse the skies. The djinn are welcoming and gracious hosts to extraplanar travelers and adventurers, a perspective not shared by Hshurha the Duchess of All Winds, the evil elemental lord of air." };
        }
    }
}
