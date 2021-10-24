using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class VersatileHeritage : Template
    {
        public static readonly Guid ID = Guid.Parse("03cbc90d-fbf1-488b-ab42-47a80884c75a");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Versatile Heritage", 
                Description = "Humanity's versatility and ambition have fueled its ascendance to be the most common ancestry in most nations throughout the world. Select a general feat of your choice for which you meet the prerequisites (as with your ancestry feat, you can select this general feat at any point during character creation)." 
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Human.ID;
        }
    }
}
