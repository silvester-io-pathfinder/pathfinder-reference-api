using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rogues
{
    public class SkillIncreases : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 2,
                Name = "Skill Increases", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You gain more skill increases than members of other classes. At 2nd level and every level thereafter, you gain a skill increase. You can use this increase to either become trained in one skill you’re untrained in, or to become an expert in one skill in which you’re already trained." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "At 7th level, you can use skill increases to become a master in a skill in which you’re already an expert, and at 15th level, you can use them to become legendary in a skill in which you’re already a master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSkillIncrease(Guid.Parse(""), Guid.Parse(""), requiredLevel: 2);
            builder.GainSkillIncrease(Guid.Parse(""), Guid.Parse(""), requiredLevel: 3);
            builder.GainSkillIncrease(Guid.Parse(""), Guid.Parse(""), requiredLevel: 4);
            builder.GainSkillIncrease(Guid.Parse(""), Guid.Parse(""), requiredLevel: 5);
            builder.GainSkillIncrease(Guid.Parse(""), Guid.Parse(""), requiredLevel: 6);
            builder.GainSkillIncrease(Guid.Parse(""), Guid.Parse(""), requiredLevel: 7);
            builder.GainSkillIncrease(Guid.Parse(""), Guid.Parse(""), requiredLevel: 8);
            builder.GainSkillIncrease(Guid.Parse(""), Guid.Parse(""), requiredLevel: 9);
            builder.GainSkillIncrease(Guid.Parse(""), Guid.Parse(""), requiredLevel: 10);
            builder.GainSkillIncrease(Guid.Parse(""), Guid.Parse(""), requiredLevel: 11);
            builder.GainSkillIncrease(Guid.Parse(""), Guid.Parse(""), requiredLevel: 12);
            builder.GainSkillIncrease(Guid.Parse(""), Guid.Parse(""), requiredLevel: 13);
            builder.GainSkillIncrease(Guid.Parse(""), Guid.Parse(""), requiredLevel: 14);
            builder.GainSkillIncrease(Guid.Parse(""), Guid.Parse(""), requiredLevel: 15);
            builder.GainSkillIncrease(Guid.Parse(""), Guid.Parse(""), requiredLevel: 16);
            builder.GainSkillIncrease(Guid.Parse(""), Guid.Parse(""), requiredLevel: 17);
            builder.GainSkillIncrease(Guid.Parse(""), Guid.Parse(""), requiredLevel: 18);
            builder.GainSkillIncrease(Guid.Parse(""), Guid.Parse(""), requiredLevel: 19);
            builder.GainSkillIncrease(Guid.Parse(""), Guid.Parse(""), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 181
            };
        }
    }
}
