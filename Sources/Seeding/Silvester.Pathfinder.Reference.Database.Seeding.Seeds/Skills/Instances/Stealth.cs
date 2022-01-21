using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Stats.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Skills.Instances
{
    public class Stealth : Template
    {
        public static readonly Guid ID = Guid.Parse("252ee579-951c-414e-bb69-7d2dfc324280");

        public override Skill GetSkill()
        {
            return new Skill
            {
                Id = ID,
                Name = "Stealth",
                HasArmorCheckPenalty = true,
                HasRecallKnowledgeAction = false,
                StatModifierId = Dexterity.ID,
                Description = "You are skilled at avoiding detection, allowing you to slip past foes, hide, or conceal an item."
            };
        }
    }
}
