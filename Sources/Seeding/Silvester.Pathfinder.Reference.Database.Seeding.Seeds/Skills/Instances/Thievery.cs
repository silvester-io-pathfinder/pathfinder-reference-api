using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Stats.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Skills.Instances
{
    public class Thievery : Template
    {
        public static readonly Guid ID = Guid.Parse("ca854fef-a519-472f-badd-f677cd8871fc");

        public override Skill GetSkill()
        {
            return new Skill
            {
                Id = ID,
                Name = "Thievery",
                HasArmorCheckPenalty = true,
                HasRecallKnowledgeAction = false,
                StatModifierId = Dexterity.ID,
                Description = "You are trained in a particular set of skills favored by thieves and miscreants."
            };
        }
    }
}
