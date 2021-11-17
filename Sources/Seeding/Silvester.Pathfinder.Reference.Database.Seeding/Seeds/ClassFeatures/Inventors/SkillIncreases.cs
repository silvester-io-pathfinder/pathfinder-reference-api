using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Inventors
{
    public class SkillIncreases : Template
    {
        public static readonly Guid ID = Guid.Parse("24fc21fa-7a24-4993-8a22-305206f21609");

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
            yield return new TextBlock { Id = Guid.Parse("04d697c6-cb0b-423b-a144-ba2dfbfbf3ba"), Type = TextBlockType.Text, Text = "At 3rd level and every 2 levels thereafter, you gain a skill increase. You can use this skill increase to become trained in one skill you're untrained in, or become an expert in one skill in which you are already trained." };
            yield return new TextBlock { Id = Guid.Parse("ce4402e9-ca93-4389-b773-c901a5e8119c"), Type = TextBlockType.Text, Text = "At 7th level, you can use skill increases to become a master in a skill in which you're already an expert, and at 15th level, you can use them to become legendary in a skill in which you're already a master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSkillIncrease(Guid.Parse("2819c754-2776-4b50-b80a-1f18540955ff"), Guid.Parse("cf3bf075-1096-4fa8-847e-216583c841f8"), requiredLevel: 3);
            builder.GainSkillIncrease(Guid.Parse("b827f78a-96c1-429e-9e65-64680ec1c070"), Guid.Parse("5a0a3d9c-7c19-4bc1-81ad-3a9430c49611"), requiredLevel: 5);
            builder.GainSkillIncrease(Guid.Parse("6f8a39ac-7abb-406a-b58f-7f52107391e8"), Guid.Parse("78777b80-a4bc-44c5-b1b2-c073a14f0589"), requiredLevel: 7);
            builder.GainSkillIncrease(Guid.Parse("f89f28c5-b23e-431b-9203-b8d3dab9ef57"), Guid.Parse("ec16cf47-6be2-4b20-9aff-21cc059995f0"), requiredLevel: 9);
            builder.GainSkillIncrease(Guid.Parse("ea58084b-a592-4026-9a68-c71f1882e400"), Guid.Parse("40f644d9-2ff3-4432-99f1-6a8b02d670a2"), requiredLevel: 11);
            builder.GainSkillIncrease(Guid.Parse("82ec6e93-50b9-42bf-af52-b48bf0b12130"), Guid.Parse("a7024fd3-259e-4127-a2e1-2974dc14c712"), requiredLevel: 13);
            builder.GainSkillIncrease(Guid.Parse("ef3fcc2f-eae9-4374-9868-69bc79ab676c"), Guid.Parse("9442be0d-517f-4044-826b-c40b810c2a71"), requiredLevel: 15);
            builder.GainSkillIncrease(Guid.Parse("20064172-a686-4998-a918-3e467e6f4d0e"), Guid.Parse("3754bc4b-cb88-4c09-ad48-84cc947eaffa"), requiredLevel: 17);
            builder.GainSkillIncrease(Guid.Parse("a82c83a1-c838-4e65-9aea-def5ac276b59"), Guid.Parse("359a34fe-08b6-4888-8bba-b601ae751e61"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a8ea98dd-b279-4bef-b507-5b1272cfb2a9"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 20
            };
        }
    }
}
