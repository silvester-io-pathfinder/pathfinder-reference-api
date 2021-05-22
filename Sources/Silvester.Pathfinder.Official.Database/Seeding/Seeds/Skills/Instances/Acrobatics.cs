using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Stats.Instances;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Skills.Instances
{
    public class Acrobatics : Template
    {
        public static readonly Guid ID = Guid.Parse("13d2e35c-3829-4bab-85c1-de00ff96248a");

        public override Skill GetSkill()
        {
            return new Skill
            {
                Id = ID,
                Name = "Acrobatics",
                HasArmorCheckPenalty = true,
                HasRecallKnowledgeAction = false,
                StatModifierId = Dexterity.ID,
                Description = "Acrobatics measures your ability to perform tasks requiring coordination and grace. When you use the Escape basic action (page 470), you can use your Acrobatics modifier instead of your unarmed attack modifier."
            };
        }
    }
}
