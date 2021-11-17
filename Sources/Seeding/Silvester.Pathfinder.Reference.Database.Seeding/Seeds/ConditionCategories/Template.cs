using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ConditionCategories
{
    public abstract class Template : EntityTemplate<ConditionCategory>
    {
        protected override ConditionCategory GetEntity(ISeedBuilder builder)
        {
            ConditionCategory category = GetConditionCategory();
            return category;
        }

        public abstract ConditionCategory GetConditionCategory();
    }
}
