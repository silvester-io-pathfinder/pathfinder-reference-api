using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ActionTypes.Instances
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
