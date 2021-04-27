using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.DeityCategories.Instances
{
    public class EmpyrealLords : AbstractDeityCategoryTemplate
    {
        public static readonly Guid ID = Guid.Parse("50493d06-f3a6-4247-abb8-58202aa07447");

        protected override DeityCategory GetCategory()
        {
            return new DeityCategory 
            { 
                Id = ID, 
                Name = "Empyreal Lords", 
                Description = "Much as demon lords and archdevils are the preeminent incarnations of malice and sin, on the side of righteousness stand the empyreal lords—exceptional beings that represent the good in the myriad everyday actions of the multiverse. Drawn from the most powerful ranks of the celestial host, the multitudinous empyreal lords include agathions, angels, archons, and azatas alike. Most of these beings gained prominence as immortal champions of virtue, though some are instead mortal paragons who ascended, while others spontaneously formed from exceptional deeds of good that echoed throughout the planes. While all empyreal lords are dedicated to good, their philosophies, interests, and personalities vary, and they don't always agree with one another. Worship of the empyreal lords is not nearly as widespread as that of the major deities, but it is still surprisingly common. Most worship takes place at small shrines, statues, or artifacts (such as the sculpture known as the Mistress of Angels in Magnimar), or simply through the doing of deeds that reflect an empyreal lord's interest or beliefs. Centers of worship like churches or cathedrals are extremely uncommon. Most followers consider worship to be an individual matter, and it is rare to see a follower of any empyreal lord proselytizing. However, adherents sometimes congregate in small groups called mystery cults, and some of these groups maintain small temples. The city of Magnimar is home to several mystery cults, as the Varisian people have long held the empyreal lords in high esteem. It is not uncommon for mystery cultists to worship multiple empyreal lords in various combinations, or even all of them, though most have a favorite patron." 
            };
        }
    }
}
