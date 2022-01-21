using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ObjectGrades
{
    public abstract class Template : EntityTemplate<ObjectGrade>
    {
        protected override ObjectGrade GetEntity(ISeedBuilder builder)
        {
            ObjectGrade grade = GetGrade();

            return grade;
        }

        public abstract ObjectGrade GetGrade();
    }
}
