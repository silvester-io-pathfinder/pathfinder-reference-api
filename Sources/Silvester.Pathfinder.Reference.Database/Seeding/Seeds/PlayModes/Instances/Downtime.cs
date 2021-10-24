using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances
{
    public class Downtime : Template
    {
        public static readonly Guid ID = Guid.Parse("879c5bce-8b92-414a-bbb5-25862981f7c6");

        protected override PlayMode GetPlayMode()
        {
            return new PlayMode
            {
                Id = ID,
                Name = "Downtime"
            };
        }
    }
}
