using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.DeityCategories.Instances
{
    public class DemonLords : Template
    {
        public static readonly Guid ID = Guid.Parse("141f20fa-a6a8-4ac7-88b8-edb2badc5b90");

        protected override DeityCategory GetCategory()
        {
            return new DeityCategory 
            { 
                Id = ID, 
                Name = "Demon Lords", 
                Description = "The Outer Rifts of the Abyss consist of unending layers of evil and depravity, many of which are ruled over by powerful, unique fiends known as demon lords. These demigods have risen above their peers through strength, cunning, or an unmatched capacity for cruelty, overseeing innumerable lesser demons that serve, fear, and revile them. Beneath them, yet more demons clamor to attain their heights of power as nascent demon lords, waiting for the right opportunity to complete their ascension. Fortunately for the mortals of the world, while the ranks of the demon lords are numerous beyond comprehension, only a small subset have so intensely turned their baleful gazes toward Golarion as to have a presence on the planet. These demon lords are served by vile cults that commit atrocities and blasphemies in exchange for power, wealth, and the opportunity to indulge their hearts' darkest desires." 
            };
        }
    }
}
