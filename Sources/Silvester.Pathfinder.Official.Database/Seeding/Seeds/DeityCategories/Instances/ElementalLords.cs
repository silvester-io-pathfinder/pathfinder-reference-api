using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.DeityCategories.Instances
{
    public class ElementalLords : Template
    {
        public static readonly Guid ID = Guid.Parse("88b9adbd-19a6-43ae-8086-01688c9c84b2");

        protected override DeityCategory GetCategory()
        {
            return new DeityCategory 
            { 
                Id = ID, 
                Name = "Elemental Lords", 
                Description = "Born amid the primal chaos of the multiverse's earliest days, the eight elemental lords are divine embodiments of the Inner Spheres' raw elemental forces. With two lords of air, two of earth, two of fire, and two of water, half their number represent the aspects of each element that mortals consider benevolent, while the others represent the malicious and destructive aspects of those same elements. When the Material Plane was born, the benevolent elemental lords seeded it with all the potential of their elements, creating planets, stars, oceans, and life. Yet as mortality evolved, it began harnessing the elements for malevolent purposes, causing anguished dissent between the benevolent elemental lords and emboldening their evil counterparts. Kelizandri, the fearsome lord of water, forged an alliance with the other evil elemental lords— Ayrzul, Hshurha, and Ymeri—to seal each good elemental lord in a prison penetrable only by combining the other three elemental powers once more; this feat has been achieved only once in the ages since. The four surviving lords have ruled their respective planes mercilessly for time uncounted, free to write the stories of their own creations, invent their own titles of nobility, and claim sole dominion over the elemental planes." 
            };
        }
    }
}
