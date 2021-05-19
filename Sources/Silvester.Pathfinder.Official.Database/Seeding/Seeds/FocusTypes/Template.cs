using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.FocusTypes
{
    public abstract class Template : EntityTemplate<FocusType>
    {
        protected override FocusType GetEntity(ModelBuilder builder)
        {
            FocusType type = GetFocusType();
            return type;
        }

        public abstract FocusType GetFocusType();
    }
}
