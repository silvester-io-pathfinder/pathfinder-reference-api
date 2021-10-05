using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ActionTypes.Instances
{
    public class OneToThreeActions : Template
    { 
        public static readonly Guid ID = Guid.Parse("9642dfa7-4b77-4584-addb-4a2fa0b46c4c");

        protected override ActionType GetActionType()
        {
            return new ActionType 
            {
                Id = ID, 
                Name = "One to Three Actions" 
            };
        }
    }
}
