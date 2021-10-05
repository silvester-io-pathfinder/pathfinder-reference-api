using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ActionTypes.Instances
{
    public class Reaction : Template
    {
        public static readonly Guid ID = Guid.Parse("668ed964-cf7f-43df-b4b3-6a89c28551aa");

        protected override ActionType GetActionType()
        {
            return new ActionType 
            {
                Id = ID,
                Name = "Reaction" 
            };
        }
    }
}
