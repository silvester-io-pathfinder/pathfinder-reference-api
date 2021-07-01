using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ConditionCategories
{
    public abstract class Template : EntityTemplate<ConditionCategory>
    {
        protected override ConditionCategory GetEntity(ModelBuilder builder)
        {
            ConditionCategory category = GetConditionCategory();
            return category;
        }

        public abstract ConditionCategory GetConditionCategory();
    }
}
