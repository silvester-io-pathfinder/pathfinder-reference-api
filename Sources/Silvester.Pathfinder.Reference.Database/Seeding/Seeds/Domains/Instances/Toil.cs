using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Toil : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Domain GetDomain()
        {
           return new Domain 
           {
               Id = ID, 
               Name = "Toil", 
               Description = "You work constantly and refuse to let anything stand in your way." 
           };
        }
    }
}
