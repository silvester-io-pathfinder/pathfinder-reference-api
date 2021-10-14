using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Stats.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Skills.Instances
{
    public class Diplomacy : Template
    {
        public static readonly Guid ID = Guid.Parse("ab6c56d1-8f95-45db-b4a1-6bae20e30c47");

        public override Skill GetSkill()
        {
            return new Skill
            {
                Id = ID,
                Name = "Diplomacy",
                HasArmorCheckPenalty = false,
                HasRecallKnowledgeAction = false,
                StatModifierId = Charisma.ID,
                Description = "You influence others through negotiation and flattery."
            };
        }
    }
}
