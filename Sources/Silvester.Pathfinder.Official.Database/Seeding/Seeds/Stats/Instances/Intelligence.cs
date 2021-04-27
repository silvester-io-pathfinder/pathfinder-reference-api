using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Stats.Instances
{
    public class Intelligence : AbstractStatTemplate
    {
        public static readonly Guid ID = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd");

        protected override Stat GetStat()
        {
            return new Stat 
            {
                Id = ID,
                Name = "Intelligence", 
                Abbreviation = "INT",
                Description = "Intelligence measures how well your character can learn and reason. A high Intelligence allows your character to analyze situations and understand patterns, and it means they can become trained in additional skills and might be able to master additional languages." 
            };
        }
    }
}
