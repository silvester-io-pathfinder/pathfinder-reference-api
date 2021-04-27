using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.DeityCategories.Instances
{
    public class Horsemen : AbstractDeityCategoryTemplate
    {
        public static readonly Guid ID = Guid.Parse("4d699f44-5321-4d9b-ba78-026c638260e9");

        protected override DeityCategory GetCategory()
        {
            return new DeityCategory 
            { 
                Id = ID, 
                Name = "Horsemen", 
                Description = "At the end of the River Styx await the rulers of Abaddon: the Four Horsemen of the Apocalypse and their daemonic brood. Hatred for living things fuels all of daemonkind, who see existence as a great mistake. Though all of the Horsemen began their lives as mortals, they are completely devoted to the eradication of reality itself. Riding atop their dreaded steeds, they strive for true apocalypse. Only when all life has been snuffed out does their mission end, and they can then consign themselves to the waiting oblivion. Only the truly nihilistic worship the Horsemen. Those who seek vengeance on all the world or lust for power are drawn to the Horsemen's easy promises, thinking they will be spared from their masters' cataclysmic mission. They never are. To the Horsemen, their followers are entirely disposable, tools with a purpose until they too are devoured." 
            };
        }
    }
}
