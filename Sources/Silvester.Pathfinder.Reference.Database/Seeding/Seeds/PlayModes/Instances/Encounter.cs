using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances
{
    public class Encounter : Template
    {
        public static readonly Guid ID = Guid.Parse("e8365274-0bd7-4546-9640-a961efc3b814");

        protected override PlayMode GetPlayMode()
        {
            return new PlayMode
            {
                Id = ID,
                Name = "Encounter"
            };
        }
    }
}
