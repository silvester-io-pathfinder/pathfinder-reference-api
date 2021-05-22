using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Races.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Heritages.Instances
{
    public class Duskwalker : Template
    {
        public static readonly Guid ID = Guid.Parse("d40a90eb-140a-43b1-94f5-fb034f62d977");

        protected override Heritage GetHeritage()
        {
           return new Heritage 
           {
               Id = ID, 
               RarityId = Rarities.Instances.Uncommon.ID, 
               Name = "Duskwalker", 
               Description = "Thanks to an ancient bargain, your soul has been reborn as a duskwalker, a planar scion with a connection to psychopomps and the Boneyard. You gain the duskwalker trait in addition to the traits from your ancestry. You also gain low-light vision, or you gain darkvision if your ancestry already has low-light vision. Neither your body nor your spirit can ever become undead. You can choose from duskwalker feats and feats from your ancestry whenever you gain an ancestry feat." 
           };
        }

        protected override IEnumerable<Guid> GetRaces()
        {
            yield return Catfolk.ID;
            yield return Gnome.ID;
            yield return Goblin.ID;
            yield return Human.ID;
            yield return Tengu.ID;
            yield return Orc.ID;
            yield return Dwarf.ID;
            yield return Kobold.ID;
            yield return Ratfolk.ID;
            yield return Elf.ID;
            yield return Halfling.ID;
        }
    }
}
