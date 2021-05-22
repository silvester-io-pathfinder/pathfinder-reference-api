using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ActionTypes.Instances
{
    public class OneOrTwoActions : Template
    {
        public static readonly Guid ID = Guid.Parse("11d73724-984e-4258-9157-6d0373363faa");

        protected override ActionType GetActionType()
        {
            return new ActionType 
            {
                Id = ID, 
                Name = "One or Two Actions" 
            };
        }
    }
}
