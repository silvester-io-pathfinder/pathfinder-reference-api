using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Stats.Instances;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Skills.Instances
{
    public class Arcana : Template
    {
        public static readonly Guid ID = Guid.Parse("6f23369f-e91f-4472-a254-648ba3ed1850");

        public override Skill GetSkill()
        {
            return new Skill
            {
                Id = ID,
                Name = "Arcana",
                HasArmorCheckPenalty = false,
                HasRecallKnowledgeAction = true,
                StatModifierId = Intelligence.ID,
                Description = "Arcana measures how much you know about arcane magic and creatures. Even if you’re untrained, you can Recall Knowledge (page 238)."
            };
        }
    }
}
