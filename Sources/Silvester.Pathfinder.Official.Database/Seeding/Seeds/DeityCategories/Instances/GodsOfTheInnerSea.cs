using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.DeityCategories.Instances
{
    public class GodsOfTheInnerSea : Template
    {
        public static readonly Guid ID = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc");

        protected override DeityCategory GetCategory()
        {
            return new DeityCategory 
            { 
                Id = ID, 
                Name = "Gods of the Inner Sea",
                Description = "The 20 primary deities of the Inner Sea region are well known due to either widespread worship or their historical tendency to help or harm the people who live there."
            };
        }
    }
}
