using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Stats.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Skills.Instances
{
    public class Intimidation : Template
    {
        public static readonly Guid ID = Guid.Parse("a14f7dbb-8a76-4b6e-8e67-6adb4f1b39b2");

        public override Skill GetSkill()
        {
            return new Skill
            {
                Id = ID,
                Name = "Intimidation",
                HasArmorCheckPenalty = false,
                HasRecallKnowledgeAction = false,
                StatModifierId = Charisma.ID,
                Description = "You bend others to your will using threats."
            };
        }
    }
}
