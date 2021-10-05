using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Family : Template
    {
        public static readonly Guid ID = Guid.Parse("49ba8be3-a11f-4d61-9b64-d8d1fd208ffe");

        protected override Domain GetDomain()
        {
           return new Domain 
           {
               Id = ID, 
               Name = "Family", 
               Description = "You aid and protect your family and community more effectively." 
           };
        }
    }
}
