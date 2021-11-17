using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ActionTypes.Instances
{
    public class FreeAction : Template
    {
        public static readonly Guid ID = Guid.Parse("4716abe4-50c3-447d-bb27-2b268667b3c2");
        
        protected override ActionType GetActionType()
        {
            return new ActionType
            {
                Id = ID, 
                Name = "Free" 
            };
        }
    }
}
