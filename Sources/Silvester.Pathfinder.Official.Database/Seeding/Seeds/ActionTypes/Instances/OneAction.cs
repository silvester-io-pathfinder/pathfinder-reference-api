using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ActionTypes.Instances
{
    public class OneAction : Template
    {
        public static readonly Guid ID = Guid.Parse("26ab8b82-ea91-4247-934b-618c724aca8b");

        protected override ActionType GetActionType()
        {
            return new ActionType
            { 
                Id = ID, 
                Name = "One Action" 
            };
        }
    }
}
