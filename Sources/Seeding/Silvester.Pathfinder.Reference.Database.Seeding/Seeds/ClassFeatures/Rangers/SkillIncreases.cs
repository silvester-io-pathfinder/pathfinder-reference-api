using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rangers
{
    public class SkillIncreases : Template
    {
        public static readonly Guid ID = Guid.Parse("5e91e3ee-310d-4425-9d7b-21a320901c0b");

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
            yield return new TextBlock { Id = Guid.Parse("11f49c51-9db2-414f-8b91-96c5cc47dd92"), Type = TextBlockType.Text, Text = "At 3rd level and every 2 levels thereafter, you gain a skill increase. You can use this skill increase to become trained in one skill you're untrained in, or become an expert in one skill in which you are already trained." };
            yield return new TextBlock { Id = Guid.Parse("c79ea1e0-3fe7-4880-a86b-0d23ef0a3eab"), Type = TextBlockType.Text, Text = "At 7th level, you can use skill increases to become a master in a skill in which you're already an expert, and at 15th level, you can use them to become legendary in a skill in which you're already a master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSkillIncrease(Guid.Parse("d2c9cfda-cef6-4335-8531-c40aa49aed91"), Guid.Parse("1fa5e439-f0ad-49ba-9022-531a44e4ad4b"), requiredLevel: 3);
            builder.GainSkillIncrease(Guid.Parse("19fde86c-6634-4438-b13e-174ff02e6606"), Guid.Parse("6517d23b-19b6-4fed-871d-21b98a5d2c71"), requiredLevel: 5);
            builder.GainSkillIncrease(Guid.Parse("e9543b82-26d6-4eef-bd1d-8ee82d365c3d"), Guid.Parse("0565295b-9606-44d0-8800-82c864642655"), requiredLevel: 7);
            builder.GainSkillIncrease(Guid.Parse("79480ee8-5b76-4f02-8fb7-4f9aac6aae5b"), Guid.Parse("750d8895-9497-41ae-bd8f-c051b855d550"), requiredLevel: 9);
            builder.GainSkillIncrease(Guid.Parse("18755874-eb5d-4c52-8c22-f01871117e21"), Guid.Parse("5afb1e74-f2ea-4071-aa55-736563b4149a"), requiredLevel: 11);
            builder.GainSkillIncrease(Guid.Parse("e171b4cb-9efb-409b-b585-afdbae61f098"), Guid.Parse("942a0c58-49bf-4c5f-9278-ce4fa7c88929"), requiredLevel: 13);
            builder.GainSkillIncrease(Guid.Parse("69693353-1e2f-4fa1-b88f-8c7dd239bb47"), Guid.Parse("6466b1df-9f45-4291-989b-dd5a63f45216"), requiredLevel: 15);
            builder.GainSkillIncrease(Guid.Parse("e847635e-f872-48cb-9d24-2f73b668f7a7"), Guid.Parse("d106e767-1975-4e6f-a977-3b95ab5bbba3"), requiredLevel: 17);
            builder.GainSkillIncrease(Guid.Parse("13f463c2-eee9-49b6-8ae7-4cab087d0dbd"), Guid.Parse("7768cc73-0963-4f37-83e1-c7be1caa5c07"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("85b6c8cd-176d-4695-962c-aa64bfe6d83f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 168
            };
        }
    }
}
