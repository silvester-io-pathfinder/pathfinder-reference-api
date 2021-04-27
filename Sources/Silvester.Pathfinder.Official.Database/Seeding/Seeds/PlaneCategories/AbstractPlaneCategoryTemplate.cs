using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PlaneCategories
{
    public abstract class AbstractPlaneCategoryTemplate : EntityTemplate<PlaneCategory>
    {
        protected override PlaneCategory GetEntity(ModelBuilder builder)
        {
            PlaneCategory category = GetPlaneCategory();
            return category;
        }

        protected abstract PlaneCategory GetPlaneCategory();
    }
}
