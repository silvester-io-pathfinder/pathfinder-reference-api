using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Planes.Instances
{
    public class Hell : Template
    {
        public static readonly Guid ID = Guid.Parse("cdd0a36f-c298-41e6-9252-d3cbc81f5bd6");

        protected override Plane GetPlane()
        {
            return new Plane 
            { 
                Id = ID, 
                CategoryId = PlaneCategories.Instances.OuterSpherePlane.ID, 
                AlignmentId = Alignments.Instances.LawfulEvil.ID, 
                Name = "Hell", 
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("4cfd5e8a-046e-4276-a0e4-3b1d6cc368ee"), Type = TextBlockType.Text, Text = "Hell is the realm of devils, the multiversal seat of tyranny and malignant law, and the divine domain of Asmodeus, the Prince of Darkness. Here every act is authorized, calculated, recorded, and set like perfectly ordered clockwork within a vast machine driven on methodical suffering and greased with pain and purification. The nine inverted layers of Hell violently oppose the surrounding fabric of the Maelstrom, each layer shaped to reflect the nature of its ruling archdevil. Avernus's volcanic wastes, ruled by Barbatos, are the marshaling place of Hell's armies, and where newly damned souls are shackled and shuffled off to their assigned torment. Dispater's layer of Dis is a great iron city: brutal, beautiful, and terrible. The layer of Erebus comprises both the sewers of Dis and the vaults and treasuries of Hell, ruled by Mammon, a great genius loci embodied by the very wealth locked within Hell's coffers. Ruled by Belial, the layer of Phlegethon hosts Hell's forges, while Geryon's watery realm of Stygia houses Hell's libraries. Moloch's smoldering, ash-draped forest realm of Malebolge is the training site of the infernal armies, and Baalzebul's frozen layer of Cocytus torments the imprisoned, starving damned. Mephistopheles rules the layer of Caina, a realm of cages and torture suspended above a pit of hungry darkness, while at the very bottom of Hell's infinite pit, Asmodeus rules unquestioned from his throne in Nessus." };
        }
    }
}
