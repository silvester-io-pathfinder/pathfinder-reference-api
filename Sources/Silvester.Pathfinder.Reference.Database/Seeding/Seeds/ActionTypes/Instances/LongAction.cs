using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ActionTypes.Instances
{
    public class LongAction : Template
    {
        public static readonly Guid ID = Guid.Parse("cbcd3d48-4ba9-4dae-8aab-e03147209784");
        
        protected override ActionType GetActionType()
        {
            return new ActionType 
            {
                Id = ID,
                Name = "Long Action"
            };
        }
    }
}
