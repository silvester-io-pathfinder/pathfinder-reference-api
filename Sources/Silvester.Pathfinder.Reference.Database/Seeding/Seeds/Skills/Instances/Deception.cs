using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Stats.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Skills.Instances
{
    public class Deception : Template
    {
        public static readonly Guid ID = Guid.Parse("2f33e759-98f4-4a19-a955-e2133197de04");

        public override Skill GetSkill()
        {
            return new Skill
            {
                Id = ID,
                Name = "Deception",
                HasArmorCheckPenalty = false,
                HasRecallKnowledgeAction = false,
                StatModifierId = Charisma.ID,
                Description = "You can trick and mislead others using disguises, lies, and other forms of subterfuge."
            };
        }
    }
}
