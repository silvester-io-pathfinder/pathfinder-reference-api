using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Planes.Instances
{
    public class EtherealPlane : Template
    {
        public static readonly Guid ID = Guid.Parse("4d67dae9-fa19-4ce6-be98-e52a7ca93f09");

        protected override Plane GetPlane()
        {
            return new Plane 
            { 
                Id = ID, 
                CategoryId = PlaneCategories.Instances.TransitivePlane.ID, 
                AlignmentId = Alignments.Instances.TrueNeutral.ID, 
                Name = "Ethereal Plane",
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return SubjectiveGravity.ID;
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("6b553367-c56e-49d9-9d4b-9955f8439c0f"), Type = TextBlockType.Text, Text = "The Ethereal Plane is a vast, misty realm overlapping each of the Inner Planes. Formed by the interacting tidal forces of creation and destruction from the Positive and Negative Energy Planes, this plane swirls with currents and eddies of fog, lit only by erratic pulses of soft green luminescence and dimly visible light of those planes it overlays, visible but ever intangible. While mortals most often use the Ethereal as a means of transit, moving by force of will in the absence of gravity to bypass barriers on their own plane, the Ethereal hosts dangers and wonders, things lost or abandoned in the mists, and things spun from local eddies in the ethereal protomatter. Predatory monsters, ether spiders, night hags and their goddess Alazhra, and all manner of incorporeal undead roam the Space Between Spaces." };
            yield return new TextBlock { Id = Guid.Parse("0eb52009-9b84-4012-8442-e80e47a91e92"), Type = TextBlockType.Text, Text = "While travelers can easily become lost in the mists with little to guide them, the plane does host some permanent structures, drawing adventurers or dissuading them. One such location, the House of the Itinerant Soul, houses wayward or lost souls, offering visitors shelter and a way to avoid turning into undead while avoiding the pull of the River of Souls. The grand cathedral also serves as a focus for mortal planar travelers, given its safety and the presence of friendly spirits willing to serve as guides in the surrounding mists." };
        }
    }
}
