using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Stats.Instances;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Skills.Instances
{
    public class Medicine : AbstractSkillTemplate
    {
        public static readonly Guid ID = Guid.Parse("b64e4795-0efe-4cf5-82e3-f4219c041137");

        public override Skill GetSkill()
        {
            return new Skill
            {
                Id = ID,
                Name = "Medicine",
                HasArmorCheckPenalty = false,
                HasRecallKnowledgeAction = true,
                StatModifierId = Wisdom.ID,
                Description = "You can patch up wounds and help people recover from diseases and poisons. Even if you’re untrained in Medicine, you can use it to Recall Knowledge (page 238)."
            };
        }
    }
}
