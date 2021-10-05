using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FeatTypes.Instances
{
    public class Class : Template
    {
        public static readonly Guid ID = Guid.Parse("cc6e0f95-a0f4-4521-9c53-7f3484be3530");

        protected override FeatType GetAction()
        {
            return new FeatType
            {
                Id = ID,
                Name = "Class"
            };
        }
    }
}
