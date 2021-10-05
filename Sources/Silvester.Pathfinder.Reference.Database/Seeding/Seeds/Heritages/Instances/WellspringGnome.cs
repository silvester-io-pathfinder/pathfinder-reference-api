using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Races.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class WellspringGnome : Template
    {
        public static readonly Guid ID = Guid.Parse("f574f17b-2c71-4a9e-adba-a91a5f5f6e22");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Wellspring Gnome", 
                Description = "Some other source of magic has a greater hold on you than the primal magic of your fey lineage does. This connection might come from an occult plane or an ancient occult song; a deity, celestial, or fiend; magical effluent left behind by a mage war; or ancient rune magic. Choose arcane, divine, or occult.You gain one cantrip from that magical tradition's spell list. You can cast this spell as an innate spell at will, as a spell of your chosen tradition. A cantrip is heightened to a spell level equal to half your level rounded up. Whenever you gain a primal innate spell from a gnome ancestry feat, change its tradition from primal to your chosen tradition." 
            };
        }

        protected override IEnumerable<Guid> GetRaces()
        {
            yield return Gnome.ID;
        }
    }
}
