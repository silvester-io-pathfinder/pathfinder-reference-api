using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Races.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class SeerElf : Template
    {
        public static readonly Guid ID = Guid.Parse("f95169fa-400b-446e-8ba2-0dca02ada9bc");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Seer Elf", 
                Description = "You have an inborn ability to detect and understand magical phenomena. You can cast the detect magic cantrip as an arcane innate spell at will. A cantrip is heightened to a spell level equal to half your level rounded up. In addition, you gain a + 1 circumstance bonus to checks to Identify Magic and to Decipher Writing of a magical nature.These skill actions typically use the Arcana, Nature, Occultism, or Religion skill." 
            };
        }

        protected override IEnumerable<Guid> GetRaces()
        {
            yield return Elf.ID;
        }
    }
}
