using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Planes.Instances
{
    public class DimensionOfTime : Template
    {
        public static readonly Guid ID = Guid.Parse("8e6d1e80-b710-4468-89d5-a97d4178fd14");

        protected override Plane GetPlane()
        {
            return new Plane 
            { 
                Id = ID, 
                CategoryId = PlaneCategories.Instances.Dimension.ID, 
                AlignmentId = Alignments.Instances.TrueNeutral.ID, 
                Name = "Dimension of Time",
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Erratic.ID;
            yield return Static.ID;
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c6b1657d-d6f8-430e-89f1-3003283a1d5e"), Type = TextBlockType.Text, Text = "Among the most obscure planes of existence, the Dimension of Time is virtually impossible to access by conventional methods of planar travel. Instead, travelers much perform complex and difficult rituals described within the pages of such monstrously rare tomes as the Necronomicon and the Book of Serpents, Ash, and Acorns: Shadows of What Was and Will Be. Compounding the plane’s obscurity, each traveler’s experience seems to be unique, and most who attempt the journey never return. Every manner of magic that interacts with the plane invariably draws the attention of creatures such as the hounds of Tindalos. The proper flow and continuity of time seems to self-correct for any attempted meddling, often with violence." };
            yield return new TextBlock { Id = Guid.Parse("b0b808c3-0341-4ca8-9ef2-537db4786ce1"), Type = TextBlockType.Text, Text = "Those few who have gained entry and returned describe the plane as a swirling storm of blurred images, the composite of millions of interwoven timelines around their own, with a single doorway allowing access to one’s own past. Travelers appear as transparent images of themselves, but the plane seems averse to any attempt to alter the past, no matter the means or the intention. Such attempts often end in the offending individual erased from existence or trapped within closed time loops to limit the damage they inflict upon the overall flow of time." };
            yield return new TextBlock { Id = Guid.Parse("b1876109-4d87-499a-8283-056344ae43be"), Type = TextBlockType.Text, Text = "Supposedly, like an eye in a storm, at the dimension’s heart is the legendary realm of Stethelos and its terrible occupant Tawil at’Umr. Tales of this realm speak only of a great city, a vast green meadow, and the rushing sound of an ocean emptying over an immense and terrible waterfall." };
        }
    }
}
