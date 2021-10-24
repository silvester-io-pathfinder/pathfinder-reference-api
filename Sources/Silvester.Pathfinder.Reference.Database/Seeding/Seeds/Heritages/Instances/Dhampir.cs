using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class Dhampir : Template
    {
        public static readonly Guid ID = Guid.Parse("36db9153-1a83-46b1-b303-47a5f4665704");

        protected override Heritage GetHeritage()
        {
           return new Heritage 
           {
               Id = ID, 
               RarityId = Rarities.Instances.Uncommon.ID, 
               Name = "Dhampir", 
               Description = "You are the scion of a vampire, half living and half undead, gifted with uncanny charm and grace, a bloodless pallor, and elongated incisors. You gain the dhampir trait, in addition to the traits from your ancestry. You have the negative healing ability, which means you are harmed by positive damage and healed by negative effects as if you were undead. You also gain low-light vision, or you gain darkvision if your ancestry already has low-light vision. You can choose from dhampir feats and feats from your ancestry whenever you gain an ancestry feat." 
           };
        }

        protected override IEnumerable<Guid> GetAncestries()
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
