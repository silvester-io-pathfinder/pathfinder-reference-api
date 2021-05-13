using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemGrades
{
    public abstract class Template : EntityTemplate<ItemGrade>
    {
        protected override ItemGrade GetEntity(ModelBuilder builder)
        {
            ItemGrade grade = GetGrade();

            return grade;
        }

        public abstract ItemGrade GetGrade();
    }
}
