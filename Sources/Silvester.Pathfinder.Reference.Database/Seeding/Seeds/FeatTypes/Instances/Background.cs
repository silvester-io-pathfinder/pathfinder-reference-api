using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FeatTypes.Instances
{
    public class Background : Template
    {
        public static readonly Guid ID = Guid.Parse("4e9d9add-edf7-48e8-8656-4a62942355e4");

        protected override FeatType GetAction()
        {
            return new FeatType
            {
                Id = ID,
                Name = "Background"
            };
        }
    }
}
