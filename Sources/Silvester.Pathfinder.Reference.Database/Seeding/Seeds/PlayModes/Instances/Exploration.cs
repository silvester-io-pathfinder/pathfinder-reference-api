using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances
{
    public class Exploration : Template
    {
        public static readonly Guid ID = Guid.Parse("58d011a5-8232-4187-8729-4a68e02e8f84");

        protected override PlayMode GetPlayMode()
        {
            return new PlayMode
            {
                Id = ID,
                Name = "Exploration"
            };
        }
    }
}
