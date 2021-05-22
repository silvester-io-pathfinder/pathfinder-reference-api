using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Stats.Instances;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Skills.Instances
{
    public class Society : Template
    {
        public static readonly Guid ID = Guid.Parse("641be10d-b069-45e9-b890-7f1254cd042c");

        public override Skill GetSkill()
        {
            return new Skill
            {
                Id = ID,
                Name = "Society",
                HasArmorCheckPenalty = false,
                HasRecallKnowledgeAction = true,
                StatModifierId = Intelligence.ID,
                Description = "You understand the people and systems that make civilization run, and you know the historical events that make societies what they are today. Further, you can use that knowledge to navigate the complex physical, societal, and economic workings of settlements. Even if you’re untrained in Society, you can use it for the following general skill actions (page 234)."
            };
        }
    }
}
