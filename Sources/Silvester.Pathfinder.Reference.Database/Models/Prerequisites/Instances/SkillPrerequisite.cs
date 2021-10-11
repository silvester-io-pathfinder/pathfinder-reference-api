using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class SkillPrerequisite : Prerequisite
    {
        public Guid? RequiredSkillId { get; set; } = null;
        public Skill? RequiredSkill { get; set; } = default!;

        public Guid RequiredProficiencyId { get; set; }
        public Proficiency RequiredProficiency { get; set; } = default!;
    }
}
