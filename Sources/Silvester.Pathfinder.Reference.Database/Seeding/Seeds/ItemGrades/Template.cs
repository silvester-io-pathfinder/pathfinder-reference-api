using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemGrades
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
