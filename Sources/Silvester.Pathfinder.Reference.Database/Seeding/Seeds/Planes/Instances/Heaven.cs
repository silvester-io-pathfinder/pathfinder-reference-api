using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Planes.Instances
{
    public class Heaven : Template
    {
        public static readonly Guid ID = Guid.Parse("84410831-a91b-4556-96a0-7eeba0653279");

        protected override Plane GetPlane()
        {
            return new Plane 
            { 
                Id = ID, 
                CategoryId = PlaneCategories.Instances.OuterSpherePlane.ID, 
                AlignmentId = Alignments.Instances.LawfulGood.ID, 
                Name = "Heaven", 
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("4269ef90-c0cf-4414-be12-1afc7f168e17"), Type = TextBlockType.Text, Text = "The great mountain of Heaven is the realm of structured benevolence made manifest. Organized into seven tiers, the mountain’s solid appearance is actually malleable, making way for a vast assemblage of varied environments to accommodate both its own celestials and the souls who migrate there. Devoted to defending the innocent and crusading against the wicked, Heaven’s archons marshal into vast armies, commanded by their own empyreal lords. Angels collaborate with the archon legions but typically act in more direct service to Heaven’s resident deities, with Iomedae, Erastil, and Torag the most prominent among them." };
            yield return new TextBlock { Id = Guid.Parse("baeae2a1-d787-4384-a414-352bc2886827"), Type = TextBlockType.Text, Text = "Petitioners known as the elect manifest at the mountain’s base, and their subsequent climb up the seemingly endless, unreachable heights is both a literal and figurative journey. Progress is about personal growth and spiritual purification as the petitioners grow more and more attuned to the plane. Likewise, progress from one layer to the next is often impossible without permission from the archons or spiritual alignment with Heaven itself. Most visitors arrive at the city of Heaven’s Shore, a place open to both traders and to pilgrims of good intent. Access beyond its heavily guarded walls is difficult, to say nothing of scaling the mountain. At its pinnacle is the Garden, Heaven’s ultimate layer. Unattended and empty, the Garden is a beautiful, transcendent mystery even to its resident deities, and the source of the plane’s call of self-perfection to its petitioners." };
        }
    }
}
