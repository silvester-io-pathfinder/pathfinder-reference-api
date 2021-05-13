using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Stats.Instances;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Skills.Instances
{
    public class Performance : Template
    {
        public static readonly Guid ID = Guid.Parse("b41f214e-5d45-46fe-8495-263c3d117a86");

        public override Skill GetSkill()
        {
            return new Skill
            {
                Id = ID,
                Name = "Performance",
                HasArmorCheckPenalty = false,
                HasRecallKnowledgeAction = false,
                StatModifierId = Charisma.ID,
                Description = "You are skilled at a form of performance, using your talents to impress a crowd or make a living."
            };
        }
    }
}
