using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ActionTypes
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
