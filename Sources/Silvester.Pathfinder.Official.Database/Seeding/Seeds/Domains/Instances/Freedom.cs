using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances
{
    public class Freedom : Template
    {
        public static readonly Guid ID = Guid.Parse("216d5607-4d52-4581-a669-06d0f2773b65");

        protected override Domain GetDomain()
        {
           return new Domain 
           {
               Id = ID, 
               Name = "Freedom", 
               Description = "You liberate yourself and others from shackles and constraints." 
           };
        }
    }
}
