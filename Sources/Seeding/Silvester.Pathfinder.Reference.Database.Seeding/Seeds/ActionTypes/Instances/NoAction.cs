using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ActionTypes.Instances
{
    public class NoAction : Template
    {
        public static readonly Guid ID = Guid.Parse("e3494cac-ca2b-41e5-9c3e-d260ebe2afc9");
        
        protected override ActionType GetActionType()
        {
            return new ActionType 
            {
                Id = ID,
                Name = "No Action"
            };
        }
    }
}
