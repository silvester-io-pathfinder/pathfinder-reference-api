using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Stats.Instances;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Skills.Instances
{
    public class Occultism : Template
    {
        public static readonly Guid ID = Guid.Parse("feb60159-48a5-4164-b2e2-54b1f0a52a26");

        public override Skill GetSkill()
        {
            return new Skill
            {
                Id = ID,
                Name = "Occultism",
                HasArmorCheckPenalty = false,
                HasRecallKnowledgeAction = true,
                StatModifierId = Intelligence.ID,
                Description = "You know a great deal about ancient philosophies, esoteric lore, obscure mysticism, and supernatural creatures. Even if you’re untrained in Occultism, you can use it to Recall Knowledge (page 238)."
            };
        }
    }
}
