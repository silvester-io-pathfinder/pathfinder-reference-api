using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Fighters
{
    public class SkillIncreases : Template
    {
        public static readonly Guid ID = Guid.Parse("933e91d9-95ca-46d4-91fd-4837c4635ea6");

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
            yield return new TextBlock { Id = Guid.Parse("0d75af0e-795f-4187-9f1c-33c284bb8678"), Type = TextBlockType.Text, Text = "At 3rd level and every 2 levels thereafter, you gain a skill increase. You can use this skill increase to become trained in one skill you're untrained in, or become an expert in one skill in which you are already trained." };
            yield return new TextBlock { Id = Guid.Parse("3bedb292-7cc4-4641-90c7-7ed3d49e5f18"), Type = TextBlockType.Text, Text = "At 7th level, you can use skill increases to become a master in a skill in which you're already an expert, and at 15th level, you can use them to become legendary in a skill in which you're already a master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSkillIncrease(Guid.Parse("363cc308-3aca-47c4-b418-957326ef06cb"), Guid.Parse("2f5a9e6c-1e81-42a3-ad4e-d905f7035fc4"), requiredLevel: 3);
            builder.GainSkillIncrease(Guid.Parse("c3432108-247c-448e-8414-acb72817b459"), Guid.Parse("36b8c7ed-d1e4-41c8-a856-8796fbda4404"), requiredLevel: 5);
            builder.GainSkillIncrease(Guid.Parse("b53bf49a-b311-4720-8f38-7c3342b9b36b"), Guid.Parse("7fa84f2b-45a3-4668-b09f-2c0320e1cad9"), requiredLevel: 7);
            builder.GainSkillIncrease(Guid.Parse("8a9cd72c-af60-4166-b360-75f2637ee45e"), Guid.Parse("9b6f492f-486b-4e83-a938-115c0c05523e"), requiredLevel: 9);
            builder.GainSkillIncrease(Guid.Parse("b91fefd6-8e38-45fc-85d9-d89bd5fb4399"), Guid.Parse("ef63c588-811a-457f-8636-904ab2e78e67"), requiredLevel: 11);
            builder.GainSkillIncrease(Guid.Parse("ce46073f-ed29-4b88-9e36-d7c692b9c802"), Guid.Parse("ce3e8a03-9a13-4f91-b9f6-9d20a9d295d1"), requiredLevel: 13);
            builder.GainSkillIncrease(Guid.Parse("d25b8a91-0f0c-4ae7-a7ea-e3eadfeb3151"), Guid.Parse("75e8890f-cc2c-4fc6-b5e5-d50f60495f91"), requiredLevel: 15);
            builder.GainSkillIncrease(Guid.Parse("12641532-c343-4006-9ff5-bd4c18afe0a3"), Guid.Parse("51cac328-a8cc-45f8-a065-92de00b88417"), requiredLevel: 17);
            builder.GainSkillIncrease(Guid.Parse("a5d4b046-489f-4dc0-acb3-bea2de5e5c9b"), Guid.Parse("e9ec3f1f-2313-4651-ab69-a391155ff997"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ad2a522c-93da-469b-bfb5-bd9286ecfcc9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 142
            };
        }
    }
}
