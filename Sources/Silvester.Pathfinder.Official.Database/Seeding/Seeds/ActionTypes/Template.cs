using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ActionTypes
{
    public abstract class Template : EntityTemplate<ActionType>
    {
        protected override ActionType GetEntity(ModelBuilder builder)
        {
            ActionType action = GetActionType();
            return action;
        }

        protected abstract ActionType GetActionType();
    }
}
