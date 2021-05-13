using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ActionTypes.Instances
{
    public class TwoOrThreeActions : Template
    {
        public static readonly Guid ID = Guid.Parse("80db0630-824c-4664-8ed8-460979a18404");

        protected override ActionType GetActionType()
        {
            return new ActionType 
            {
                Id = ID, 
                Name = "Two or Three Actions" 
            };
        }
    }
}
