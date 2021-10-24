using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Investigators
{
    public class SkillfulLessons : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 3,
                Name = "Skillful Lessons", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "At 3rd level and every odd-numbered level thereafter, you gain a skill feat. This feat must be for an Intelligence-, Wisdom-, or Charisma-based skill, or for the skill you gained from your methodology." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSkillfulLesson(Guid.Parse(""), Guid.Parse(""), requiredLevel: 3);
            builder.GainSkillfulLesson(Guid.Parse(""), Guid.Parse(""), requiredLevel: 5);
            builder.GainSkillfulLesson(Guid.Parse(""), Guid.Parse(""), requiredLevel: 7);
            builder.GainSkillfulLesson(Guid.Parse(""), Guid.Parse(""), requiredLevel: 9);
            builder.GainSkillfulLesson(Guid.Parse(""), Guid.Parse(""), requiredLevel: 11);
            builder.GainSkillfulLesson(Guid.Parse(""), Guid.Parse(""), requiredLevel: 13);
            builder.GainSkillfulLesson(Guid.Parse(""), Guid.Parse(""), requiredLevel: 15);
            builder.GainSkillfulLesson(Guid.Parse(""), Guid.Parse(""), requiredLevel: 17);
            builder.GainSkillfulLesson(Guid.Parse(""), Guid.Parse(""), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 59
            };
        }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static void GainSkillfulLesson(this BooleanEffectBuilder builder, Guid id)
        {
            builder
                .AddOr(Guid.Parse(""), or =>
                {
                    or.GainAnyStatSkillFeat(Guid.Parse(""), Stats.Instances.Intelligence.ID);
                    or.GainAnyStatSkillFeat(Guid.Parse(""), Stats.Instances.Wisdom.ID);
                    or.GainAnyStatSkillFeat(Guid.Parse(""), Stats.Instances.Charisma.ID);
                    or.GainChosenMethodologyStatSkillFeat(Guid.Parse(""));
                });
        }

        public static void GainSkillfulLesson(this BooleanEffectBuilder builder, Guid id, Guid prerequisiteId, int requiredLevel)
        {
            builder
                .AddOr(Guid.Parse(""), or =>
                {
                    or.GainAnyStatSkillFeat(Guid.Parse(""), Stats.Instances.Intelligence.ID);
                    or.GainAnyStatSkillFeat(Guid.Parse(""), Stats.Instances.Wisdom.ID);
                    or.GainAnyStatSkillFeat(Guid.Parse(""), Stats.Instances.Charisma.ID);
                    or.GainChosenMethodologyStatSkillFeat(Guid.Parse(""));

                    or.AddPrerequisites(Guid.Parse(""), prerequisites => 
                    {
                        prerequisites.HaveSpecificLevel(prerequisiteId, Comparator.GreaterThanOrEqualTo, requiredLevel);
                    });
                });
        }
    }
}
