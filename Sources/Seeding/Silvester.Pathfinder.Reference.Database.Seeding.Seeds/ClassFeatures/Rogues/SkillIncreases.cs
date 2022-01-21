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
        public static readonly Guid ID = Guid.Parse("f8d6c818-1474-4cd2-81ed-1bdc02e9bdf3");

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
            yield return new TextBlock { Id = Guid.Parse("84f360a1-f996-4af9-89b8-35cbfd3cfbb1"), Type = TextBlockType.Text, Text = "You gain more skill increases than members of other classes. At 2nd level and every level thereafter, you gain a skill increase. You can use this increase to either become trained in one skill you�re untrained in, or to become an expert in one skill in which you�re already trained." };
            yield return new TextBlock { Id = Guid.Parse("66670794-a3cb-4734-95f4-5baba682bf30"), Type = TextBlockType.Text, Text = "At 7th level, you can use skill increases to become a master in a skill in which you�re already an expert, and at 15th level, you can use them to become legendary in a skill in which you�re already a master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSkillIncrease(Guid.Parse("8ff6b6fa-1cde-42dc-b637-684aada4590c"), Guid.Parse("341cfbbd-617a-4720-a1d3-52656f45105d"), requiredLevel: 2);
            builder.GainSkillIncrease(Guid.Parse("6c16196f-ef15-41e1-8a0e-7b2f39296c12"), Guid.Parse("10276900-34fc-4792-906b-9b6b6438dca7"), requiredLevel: 3);
            builder.GainSkillIncrease(Guid.Parse("b3a995d6-ab13-423a-89b0-09dab8173b22"), Guid.Parse("6aadc081-f88b-4d95-a994-2589dc0acc57"), requiredLevel: 4);
            builder.GainSkillIncrease(Guid.Parse("977265c0-9be5-4a4f-a1ef-58b9a132eb43"), Guid.Parse("cd0a9484-6803-4ffc-b895-14b95d684a7c"), requiredLevel: 5);
            builder.GainSkillIncrease(Guid.Parse("56c26e34-6022-46d0-82db-592698c81ca6"), Guid.Parse("66d8c25f-c990-44ec-88d4-f98a61688d67"), requiredLevel: 6);
            builder.GainSkillIncrease(Guid.Parse("b778d634-cc1f-414e-91cd-9c346ead2967"), Guid.Parse("10ef0b0b-03c3-46bd-96eb-7663b2de8d35"), requiredLevel: 7);
            builder.GainSkillIncrease(Guid.Parse("1769e614-5cff-415e-a096-17b18441e5cb"), Guid.Parse("d8e51398-e483-4463-812b-daab69209783"), requiredLevel: 8);
            builder.GainSkillIncrease(Guid.Parse("54b6627b-fcac-43e3-9d96-d4cb8dc171b9"), Guid.Parse("b9c18bac-8dda-40c2-bc8a-098590a691bb"), requiredLevel: 9);
            builder.GainSkillIncrease(Guid.Parse("77185788-f1cb-499e-a268-0be06f8fe828"), Guid.Parse("3471d314-d729-4a80-b0f7-bb4f1658bee5"), requiredLevel: 10);
            builder.GainSkillIncrease(Guid.Parse("76dfe196-853b-4304-9cbe-315d765dfa14"), Guid.Parse("3f206453-d053-459b-b364-ff07218457a8"), requiredLevel: 11);
            builder.GainSkillIncrease(Guid.Parse("6437ed50-a5f5-4783-a13a-5eb1451d2e19"), Guid.Parse("e108635f-990d-4caf-8fa9-8acacbe9caf0"), requiredLevel: 12);
            builder.GainSkillIncrease(Guid.Parse("2682c198-4dad-4e1b-96f6-2da6684ce80c"), Guid.Parse("78589c3d-272d-43e4-8f20-b330ebf83fb9"), requiredLevel: 13);
            builder.GainSkillIncrease(Guid.Parse("64336b6b-56e2-4279-be20-be4069af7b48"), Guid.Parse("089cfa27-111a-43c4-b98a-e8ad105bc5f9"), requiredLevel: 14);
            builder.GainSkillIncrease(Guid.Parse("ff894eed-b3b3-4687-9be2-792b6412921d"), Guid.Parse("7275a684-cc22-46b5-9b28-995bb9b30823"), requiredLevel: 15);
            builder.GainSkillIncrease(Guid.Parse("a26897dd-eaea-489b-b9bc-c04cf9a9821d"), Guid.Parse("1bab5b58-8d6f-40a5-9f33-35b52faad665"), requiredLevel: 16);
            builder.GainSkillIncrease(Guid.Parse("ff704649-345c-4bc0-9a12-6f975eaeedfa"), Guid.Parse("d9838676-cab0-4c4f-9985-e1baa5b6ec28"), requiredLevel: 17);
            builder.GainSkillIncrease(Guid.Parse("94d9821a-c00b-47ec-8a63-5b7de56bf2cb"), Guid.Parse("ea6136f4-1ee5-44e2-89f5-5e794c420d41"), requiredLevel: 18);
            builder.GainSkillIncrease(Guid.Parse("b931a193-82fd-439b-8c65-8279553757f5"), Guid.Parse("ed4bff4c-f864-42ba-8b35-969dec6a7095"), requiredLevel: 19);
            builder.GainSkillIncrease(Guid.Parse("2eb08334-c8f4-408e-9ebd-172759b6e5c3"), Guid.Parse("87a7d8f1-edb0-450c-92bb-15dfdf6b1e47"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("145c6e5a-a0a6-4849-9cf0-e85ee7e6a990"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 181
            };
        }
    }
}
