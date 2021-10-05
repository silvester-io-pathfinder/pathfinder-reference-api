using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Stats.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Skills.Instances
{
    public class Religion : Template
    {
        public static readonly Guid ID = Guid.Parse("6a672190-7918-4fbd-a2d7-2d69f9d2a794");

        public override Skill GetSkill()
        {
            return new Skill
            {
                Id = ID,
                Name = "Religion",
                HasArmorCheckPenalty = false,
                HasRecallKnowledgeAction = true,
                StatModifierId = Wisdom.ID,
                Description = "The secrets of deities, dogma, faith, and the realms of divine creatures both sublime and sinister are open to you. You also understand how magic works, though your training imparts a religious slant to that knowledge. Even if you’re untrained in Religion, you can use it to Recall Knowledge (page 238)."
            };
        }
    }
}
