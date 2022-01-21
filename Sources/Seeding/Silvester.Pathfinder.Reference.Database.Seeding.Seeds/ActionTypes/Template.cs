using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ActionTypes
{
    public abstract class Template : EntityTemplate<ActionType>
    {
        protected override ActionType GetEntity(ISeedBuilder builder)
        {
            ActionType action = GetActionType();
            return action;
        }

        protected abstract ActionType GetActionType();
    }
}
