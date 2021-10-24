using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ActionTypes.Instances
{
    public class ThreeActions : Template
    {
        public static readonly Guid ID = Guid.Parse("3fa12bb8-7b63-4c36-8e6e-d3cdd81580b8");
        
        protected override ActionType GetActionType()
        {
            return new ActionType 
            { 
                Id = ID,
                Name = "Three Actions" 
            };
        }
    }
}
