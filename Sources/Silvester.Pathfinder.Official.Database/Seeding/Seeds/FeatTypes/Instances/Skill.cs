using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.FeatTypes.Instances
{
    public class Skill : Template
    {
        public static readonly Guid ID = Guid.Parse("5b6fe59e-cc09-4a3c-b555-3b5f22aafe83");
        protected override FeatType GetAction()
        {
            return new FeatType
            {
                Id = ID,
                Name = "Skill"
            };
        }
    }
}
