using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Stats.Instances;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Skills.Instances
{
    public class Survival : Template
    {
        public static readonly Guid ID = Guid.Parse("d8fd543c-7284-451d-8882-583970e9d917");

        public override Skill GetSkill()
        {
            return new Skill
            {
                Id = ID,
                Name = "Survival",
                HasArmorCheckPenalty = false,
                HasRecallKnowledgeAction = false,
                StatModifierId = Wisdom.ID,
                Description = "You are adept at living in the wilderness, foraging for food and building shelter, and with training you discover the secrets of tracking and hiding your trail. Even if you’re untrained, you can still use Survival to Subsist (page 240)."
            };
        }
    }
}
