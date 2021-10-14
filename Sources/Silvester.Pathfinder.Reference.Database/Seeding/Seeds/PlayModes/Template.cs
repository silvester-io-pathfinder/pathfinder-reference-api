using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes
{
    public abstract class Template : EntityTemplate<PlayMode>
    {
        protected override PlayMode GetEntity(ModelBuilder builder)
        {
            PlayMode mode = GetPlayMode();
            return mode;
        }

        protected abstract PlayMode GetPlayMode();
    }
}
