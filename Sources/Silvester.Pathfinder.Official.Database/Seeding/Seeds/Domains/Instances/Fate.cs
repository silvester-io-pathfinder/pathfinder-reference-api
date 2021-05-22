using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances
{
    public class Fate : Template
    {
        public static readonly Guid ID = Guid.Parse("696cb38a-1f8f-4506-b3e6-06c5b5e802af");

        protected override Domain GetDomain()
        {
           return new Domain 
           {
               Id = ID, 
               Name = "Fate", 
               Description = "You see and understand hidden inevitabilities." 
           };
        }
    }
}
