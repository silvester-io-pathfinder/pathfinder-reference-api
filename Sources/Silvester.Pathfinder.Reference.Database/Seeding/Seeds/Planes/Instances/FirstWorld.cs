using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Planes.Instances
{
    public class FirstWorld : Template
    {
        public static readonly Guid ID = Guid.Parse("e48dae17-e2ad-48fa-8cfb-756dea200ca5");

        protected override Plane GetPlane()
        {
            return new Plane 
            { 
                Id = ID, 
                CategoryId = PlaneCategories.Instances.TransitivePlane.ID, 
                AlignmentId = Alignments.Instances.TrueNeutral.ID, 
                Name = "First World",
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Erratic.ID;
            yield return Metamorphic.ID;
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c369da7a-c404-49f5-81fc-80820230a729"), Type = TextBlockType.Text, Text = "The First World was a first draft of the Material Plane, crafted by divinities to test their metaphorical crafting materials and palettes of colors before setting it aside to create a second, final version of their work. A realm of extremes—savage, primal, and beautiful—with colors and sensations brighter and more intense than the mundane world created after it, the First World is populated by fey and the divine entities known as the Eldest. Mirroring mercurial fey whimsy, the First World’s laws of nature constantly and unpredictably change. Distance and time are wildly inconsistent, such that mortal travelers might spend an hour or a day within the First World, only to find a century or only a few seconds passed once they return to their own plane." };
            yield return new TextBlock { Id = Guid.Parse("fbea998f-0e22-4def-8d39-bd9ed1f34b00"), Type = TextBlockType.Text, Text = "The First World stands outside the cycle of souls, something the fey call the Great Abandonment, save for rare worshippers of the Eldest whose souls incarnate here as fey. However, the plane’s proximity to the Positive Energy Plane provides an environment bursting with all manner of strange life and a general absence of true death for its native fey unless they leave—as did gnomes. Natural gates in wild places of the mortal realm connect to the First World, which fey often use to visit the Material Plane or ensnare mortals for their own capricious desires." };
        }
    }
}
