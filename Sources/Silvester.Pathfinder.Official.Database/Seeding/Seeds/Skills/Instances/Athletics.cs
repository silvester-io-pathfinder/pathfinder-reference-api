using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Stats.Instances;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Skills.Instances
{
    public class Athletics : Template
    {
        public static readonly Guid ID = Guid.Parse("8b35c13a-46fd-4018-bb18-11c0f156f708");

        public override Skill GetSkill()
        {
            return new Skill
            {
                Id = ID,
                Name = "Athletics",
                HasArmorCheckPenalty = true,
                HasRecallKnowledgeAction = false,
                StatModifierId = Strength.ID,
                Description = "Athletics allows you to perform deeds of physical prowess. When you use the Escape basic action (page 470), you can use your Athletics modifier instead of your unarmed attack modifier."
            };
        }
    }
}
