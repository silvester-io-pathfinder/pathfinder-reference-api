using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Extensions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Investigators
{
    public class SkillfulLessons : Template
    {
        public static readonly Guid ID = Guid.Parse("1e20d1c1-9e34-4b00-9f82-f023e9b3a7bd");

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
            yield return new TextBlock { Id = Guid.Parse("857ba69c-e1f1-4f9e-b830-a9a06f5f5359"), Type = TextBlockType.Text, Text = "At 3rd level and every odd-numbered level thereafter, you gain a skill feat. This feat must be for an Intelligence-, Wisdom-, or Charisma-based skill, or for the skill you gained from your methodology." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSkillfulLesson(Guid.Parse("09b0ffff-e47b-42bc-898d-0ea3196e0e5b"), Guid.Parse("5d915b54-5df3-451f-9e45-261f3ac9937b"), requiredLevel: 3);
            builder.GainSkillfulLesson(Guid.Parse("831ee441-e2fb-4cb9-b759-f176761a1baf"), Guid.Parse("cdb55c90-a865-47ad-b85c-9c5a455e0f05"), requiredLevel: 5);
            builder.GainSkillfulLesson(Guid.Parse("d9c88549-1c9d-4287-b439-34ce268b4d86"), Guid.Parse("543a7ade-9c58-4ee2-84dc-c907914ee6e0"), requiredLevel: 7);
            builder.GainSkillfulLesson(Guid.Parse("2ae395ca-245b-477f-b0aa-2cae70c123af"), Guid.Parse("1604113f-4448-487a-8e22-d0a3efd798c3"), requiredLevel: 9);
            builder.GainSkillfulLesson(Guid.Parse("0fff26be-d888-4ba8-9348-297e366d67df"), Guid.Parse("a9d247ea-4ce1-49c1-9c3a-d492488eedaf"), requiredLevel: 11);
            builder.GainSkillfulLesson(Guid.Parse("9de19b63-8083-40ee-bcfc-c53e5a91e052"), Guid.Parse("a9a3a076-bcff-4e98-847d-9d1a380233ab"), requiredLevel: 13);
            builder.GainSkillfulLesson(Guid.Parse("ed3d3fce-f01d-4023-b4e0-26827d3419e5"), Guid.Parse("57624765-de28-441e-8328-fc251df4ed05"), requiredLevel: 15);
            builder.GainSkillfulLesson(Guid.Parse("884f21b6-1b3d-4a39-aae2-6b1dc57821ec"), Guid.Parse("ca0a4f85-255c-423b-8670-094b22165b4b"), requiredLevel: 17);
            builder.GainSkillfulLesson(Guid.Parse("31e20084-bc0d-4b86-8466-37342ff07860"), Guid.Parse("e9d1406a-edbc-4a39-9e40-06532fc1a3b5"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fd01b8be-1ba4-4953-8f49-94ee568ab2e2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 59
            };
        }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static void GainSkillfulLesson(this BooleanEffectBuilder builder, Guid id, Guid prerequisiteId, int requiredLevel)
        {
            builder
                .AddOr(id, or =>
                {
                    or.GainAnyStatSkillFeat(id.Increment(1), Stats.Instances.Intelligence.ID);
                    or.GainAnyStatSkillFeat(id.Increment(2), Stats.Instances.Wisdom.ID);
                    or.GainAnyStatSkillFeat(id.Increment(3), Stats.Instances.Charisma.ID);
                    or.GainChosenMethodologyStatSkillFeat(id.Increment(4));

                    or.AddPrerequisites(id.Increment(5), prerequisites => 
                    {
                        prerequisites.HaveSpecificLevel(prerequisiteId, Comparator.GreaterThanOrEqualTo, requiredLevel);
                    });
                });
        }
    }
}
