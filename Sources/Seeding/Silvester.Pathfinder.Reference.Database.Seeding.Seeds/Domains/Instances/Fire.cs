using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Fire : Template
    {
        public static readonly Guid ID = Guid.Parse("f1a372b7-a9bc-4571-b0ca-69780008e40a");

        protected override Domain GetDomain()
        {
           return new Domain 
           {
               Id = ID, 
               Name = "Fire", 
               Description = "You control flame." 
           };
        }
    }
}
