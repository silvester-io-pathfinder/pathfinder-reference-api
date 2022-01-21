using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Stats.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Skills.Instances
{
    public class Nature : Template
    {
        public static readonly Guid ID = Guid.Parse("3707c645-9e77-4eb7-bf63-f4d65f471f25");

        public override Skill GetSkill()
        {
            return new Skill
            {
                Id = ID,
                Name = "Nature",
                HasArmorCheckPenalty = false,
                HasRecallKnowledgeAction = true,
                StatModifierId = Wisdom.ID,
                Description = "You know about the natural world, and you command and train animals and magical beasts. Even if you're untrained in Nature, you can use it to Recall Knowledge (page 238)."
            };
        }
    }
}
