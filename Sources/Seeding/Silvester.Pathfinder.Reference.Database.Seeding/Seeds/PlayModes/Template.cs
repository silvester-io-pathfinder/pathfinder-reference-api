using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes
{
    public abstract class Template : EntityTemplate<PlayMode>
    {
        protected override PlayMode GetEntity(ISeedBuilder builder)
        {
            PlayMode mode = GetPlayMode();
            return mode;
        }

        protected abstract PlayMode GetPlayMode();
    }
}
