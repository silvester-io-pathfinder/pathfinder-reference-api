using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Immunities.Instances
{
    public class CriticalHits : Template
    {
        public static readonly Guid ID = Guid.Parse("7bbfc8dc-05c1-49f6-938d-07eb81d7ad83");

        protected override Immunity GetHazardImmunity()
        {
            return new Immunity 
            {
                Id = ID, 
                Name = "Critical Hits" 
            };
        }
    }
}
