using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances
{
    public class Decay : Template
    {
        public static readonly Guid ID = Guid.Parse("ab698922-2a43-4eb1-a400-2b96abcbb255");

        protected override Domain GetDomain()
        {
            return new Domain 
            { 
                Id = ID, 
                Name = "Decay", 
                Description = "You have the power to spoil and deteriorate matter." 
            };
        }
    }
}
