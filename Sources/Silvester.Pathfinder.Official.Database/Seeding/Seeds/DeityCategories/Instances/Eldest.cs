using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.DeityCategories.Instances
{
    public class Eldest : AbstractDeityCategoryTemplate
    {
        public static readonly Guid ID = Guid.Parse("e2cdeaf6-9ea1-464c-aa82-045d042da2b5");

        protected override DeityCategory GetCategory()
        {
            return new DeityCategory 
            { 
                Id = ID, 
                Name = "Eldest", 
                Description = "When the gods abandoned the First World—their initial rough draft of creation shaped in distant prehistory— native beings of incredible power stepped in to fill the vacuum. These beings, called the Eldest, hold deific power over the First World but have little of the other gods' aspirations. The Eldest don't concern themselves with expanding their followings or advocating particular ideologies. Many barely acknowledge their worshippers at all, concerning themselves only with their own mysterious motivations and doling out divine power merely because they have much to spare and doing so amuses them." 
            };
        }
    }
}
