using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PlaneCategories.Instances
{
    public class Dimension : AbstractPlaneCategoryTemplate
    {
        public static readonly Guid ID = Guid.Parse("906654b0-cf06-4b89-981b-07b50afa956d");

        protected override PlaneCategory GetPlaneCategory()
        {
            return new PlaneCategory 
            { 
                Id = ID, 
                Name = "Dimension", 
                Description = "Existing in the metaphorical space between the Transitive Planes and smaller, finite demiplanes, dimensions are a category unto themselves, defying the neat categorization of planar scholars and adventurers. Seemingly infinite in scale, not necessarily spatial in the same way as a plane, and overlaying every other plane at once—including one another—dimensions and planes are most significantly differentiated in how each of them breaks the commonly held rules of the other. Although some scholars include other extraplanar realms within the ranks of dimensions, only two such realms are uniformly agreed upon and classified as such. The Dreamlands, also known as the Dimension of Dreams, is readily accessed by mortal dreamers, while the Dimension of Time is notorious for the near impossibility of accessing it as well as the bizarre, often deadly restrictions upon travel to and within its bounds." 
            };
        }
    }
}
