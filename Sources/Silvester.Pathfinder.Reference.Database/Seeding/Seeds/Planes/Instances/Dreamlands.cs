using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Planes.Instances
{
    public class Dreamlands : Template
    {
        public static readonly Guid ID = Guid.Parse("08350a3e-6f60-4b40-b5f0-8ec05e70204e");

        protected override Plane GetPlane()
        {
            return new Plane 
            { 
                Id = ID, 
                CategoryId = PlaneCategories.Instances.Dimension.ID, 
                AlignmentId = Alignments.Instances.TrueNeutral.ID, 
                Name = "Dreamlands", 
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Flowing.ID;
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("37662df3-7223-4cbe-8939-b70dd975ec2b"), Type = TextBlockType.Text, Text = "Created and sustained by the collective dreams of sleeping mortals, the Dreamlands (also called the Dimension of Dreams) overlays the Ethereal Plane. When a creature dreams, regardless of the location of their physical body, they interact directly with the Dreamlands. Sleeping creatures cast themselves into the plane in idealized avatars known as lucid bodies, and their dreamscapes are immune to outside entry by standard magic such as plane shift, requiring obscure, more specialized spells to access. The dreamers of each mortal world generate a cluster of dreamscapes, like drifting bubbles atop a deeper ocean of permanent dreams formed from the collective mass of slumbering desires, dreams of especially powerful dreamers, and the dreams of ancient, obscure entities—including the gods of the Elder Mythos. While most dreamscapes are safe, travelers in the deep, permanent Dreamlands face living, animate dreams and the predation of night hags from the Ethereal Plane, as well as stranger beings spawned within the core itself." };
            yield return new TextBlock { Id = Guid.Parse("97a53dde-ea5d-4e22-8768-c4e7c032c139"), Type = TextBlockType.Text, Text = "Some scholars postulate a distinct region within the dimension for nightmares, much as the more stable inner portions of the dimension exist separately from the transient, ever-forming and evaporating mortal dreamscapes at its edges. Others conflate this nightmare region with the demiplane of Leng, while still others dismiss this notion but speculate that Leng is somehow accessible to dreamers who intentionally seek it out." };
        }
    }
}
