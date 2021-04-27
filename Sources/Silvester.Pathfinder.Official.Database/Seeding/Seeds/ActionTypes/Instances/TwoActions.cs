using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ActionTypes.Instances
{
    public class TwoActions : AbstractActionTypeTemplate
    {
        public static readonly Guid ID = Guid.Parse("fe122850-b449-482d-8350-ac21e8985594");
        
        protected override ActionType GetActionType()
        {
            return new ActionType 
            {
                Id = ID, 
                Name = "Two Actions" 
            };
        }
    }
}
