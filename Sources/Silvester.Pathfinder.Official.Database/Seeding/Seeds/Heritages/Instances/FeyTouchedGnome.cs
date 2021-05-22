using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Races.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Heritages.Instances
{
    public class FeyTouchedGnome : Template
    {
        public static readonly Guid ID = Guid.Parse("6820eb19-bb58-4d56-9fdf-ce57f72b75d6");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Fey-Touched Gnome", 
                Description = "The blood of the fey is so strong within you that you're truly one of them. You gain the fey trait, in addition to the gnome and humanoid traits. Choose one cantrip from the primal spell list. You can cast this spell as a primal innate spell at will. A cantrip is heightened to a spell level equal to half your level rounded up. You can change this cantrip to a different one from the same list once per day by meditating to realign yourself with the First World; this is a 10-minute activity that has the concentrate trait." 
            };

        }

        protected override IEnumerable<Guid> GetRaces()
        {
            yield return Gnome.ID;
        }
    }
}
