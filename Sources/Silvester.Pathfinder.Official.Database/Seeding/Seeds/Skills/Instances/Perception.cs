using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Stats.Instances;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Skills.Instances
{
    public class Perception : AbstractSkillTemplate
    {
        public static readonly Guid ID = Guid.Parse("eeb5a099-361f-41ab-aafd-7672f47bf9c3");

        public override Skill GetSkill()
        {
            return new Skill
            {
                Id = ID,
                Name = "Perception",
                HasArmorCheckPenalty = false,
                HasRecallKnowledgeAction = false,
                StatModifierId = Wisdom.ID,
                Description = "Perception measures your ability to be aware of your environment. Every creature has Perception, which works with and is limited by a creature’s senses (described on page 464). Whenever you need to attempt a check based on your awareness, you’ll attempt a Perception check. Your Perception uses your Wisdom modifier, so you’ll use the following formula when attempting a Perception check."
            };
        }
    }
}
