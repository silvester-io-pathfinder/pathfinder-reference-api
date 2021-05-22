using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.DeityCategories.Instances
{
    public class MonitorDemigods : Template
    {
        public static readonly Guid ID = Guid.Parse("45bda584-ba71-45c5-a91d-a3e9e07ee0a3");

        protected override DeityCategory GetCategory()
        {
            return new DeityCategory 
            { 
                Id = ID, 
                Name = "Monitor Demigods",
                Description = "While fiends exploit mortals' baser natures and celestials encourage their better selves, monitors are concerned more with method than morality, from the rigid law of aeons and inevitables to the pragmatic neutrality of psychopomps, to the unpredictable chaos of proteans. Rather than immersing themselves in issues of philosophy, monitors take a more cosmic approach, battling each other over universal laws, the planes, and reality itself. Mortals worship monitor demigods just as they do empyreal lords and fiendish demigods. Some are drawn to the enigmatic Monad or primordial inevitables out of a desire for control or the reassurance of an orderly universe—often those in governance or academia. Artists and bon vivants who seek the creativity and freedom offered by the paragons of chaos revere protean lords. While many assume worshippers of psychopomp ushers to be morbid, that is rarely the case. Psychopomp worship is also found among those who bring life into the world, such as midwives and farmers, and those who eschew idealism for more practical philosophies." 
            };
        }
    }
}
