using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Generic
{
    public class SkillIncreases : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 3,
                Name = "Skill Increases", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "At 3rd level and every 2 levels thereafter, you gain a skill increase. You can use this skill increase to become trained in one skill you're untrained in, or become an expert in one skill in which you are already trained." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "At 7th level, you can use skill increases to become a master in a skill in which you're already an expert, and at 15th level, you can use them to become legendary in a skill in which you're already a master." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSkillIncreaseEffect { Id = Guid.Parse(""), Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 3 } } } };
            yield return new GainSkillIncreaseEffect { Id = Guid.Parse(""), Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 5 } } } };
            yield return new GainSkillIncreaseEffect { Id = Guid.Parse(""), Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 7 } } } };
            yield return new GainSkillIncreaseEffect { Id = Guid.Parse(""), Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 9 } } } };
            yield return new GainSkillIncreaseEffect { Id = Guid.Parse(""), Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 11 } } } };
            yield return new GainSkillIncreaseEffect { Id = Guid.Parse(""), Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 13 } } } };
            yield return new GainSkillIncreaseEffect { Id = Guid.Parse(""), Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 15 } } } };
            yield return new GainSkillIncreaseEffect { Id = Guid.Parse(""), Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 17 } } } };
            yield return new GainSkillIncreaseEffect { Id = Guid.Parse(""), Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 19 } } } };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 206
            };
        }
    }
}
