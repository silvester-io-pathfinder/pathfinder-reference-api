using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Races.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Heritages.Instances
{
    public class Tiefling : AbstractHeritageTemplate
    {
        public static readonly Guid ID = Guid.Parse("7815fbcb-db7c-42fb-90fd-325aaee20d26");

        protected override Heritage GetHeritage()
        {
           return new Heritage 
           {
               Id = ID, 
               RarityId = Rarities.Instances.Uncommon.ID, 
               Name = "Tiefling", 
               Description = "You descend from fiends or bear the mark of the fiendish realms, manifesting as some unusual feature that belies your heritage, such as horns or a tail. You gain the tiefling trait, in addition to the traits from your ancestry. You also gain low-light vision, or you gain darkvision if your ancestry already has low-light vision. You can choose from tiefling feats and feats from your ancestry whenever you gain an ancestry feat." 
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
