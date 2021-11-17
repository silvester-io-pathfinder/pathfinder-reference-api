using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemGrades
{
    public abstract class Template : EntityTemplate<ItemGrade>
    {
        protected override ItemGrade GetEntity(ISeedBuilder builder)
        {
            ItemGrade grade = GetGrade();

            return grade;
        }

        public abstract ItemGrade GetGrade();
    }
}
