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
    public class SkillFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("170eeb27-18b7-4aca-abfb-ccba4b92eec6");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1, 
                Name = "Skill Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("330d7342-c297-4307-8526-9ab6159ae12b"), Type = TextBlockType.Text, Text = "You gain skill feats more often than others. At 1st level and every level thereafter, you gain a skill feat. Skill feats can be found in Chapter 5 of the Core Rulebook and have the skill trait." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnySkillFeat(Guid.Parse("431c8f3c-0b8c-4d25-b98d-5e01c731dff5"), Guid.Parse("11b67cf3-c5f3-45d7-97a4-14df9e553647"), requiredLevel: 1);
            builder.GainAnySkillFeat(Guid.Parse("acbb0e69-bd09-4c3f-bdc9-a99e6287093b"), Guid.Parse("28bb15b4-529e-47de-9b44-e468cef14d53"), requiredLevel: 2);
            builder.GainAnySkillFeat(Guid.Parse("b0e6d6fc-cd64-4b6d-ace4-4cf48adb387e"), Guid.Parse("11c928be-e3f3-4c08-91d7-778a7c498ce9"), requiredLevel: 3);
            builder.GainAnySkillFeat(Guid.Parse("46a038a9-4a96-4b42-9b4d-110cea1697c6"), Guid.Parse("073a139f-721d-492a-8e74-ee13c8c4534e"), requiredLevel: 4);
            builder.GainAnySkillFeat(Guid.Parse("146eb6cd-5811-4e93-a353-754297455d96"), Guid.Parse("02c8e0e0-99ee-4778-8136-65278ab96c33"), requiredLevel: 5);
            builder.GainAnySkillFeat(Guid.Parse("6cf1c3c2-0346-487b-9c22-7608a5da7a8e"), Guid.Parse("76abe99b-eedf-4bf4-8cb0-b6ae41131b4a"), requiredLevel: 6);
            builder.GainAnySkillFeat(Guid.Parse("cf80adfc-e2d1-4764-9a71-c73072e83cdd"), Guid.Parse("806424d9-64d6-4be6-b306-f2e8e947b760"), requiredLevel: 7);
            builder.GainAnySkillFeat(Guid.Parse("321e4d25-b643-4ba7-a68d-cbaf6dc22ef5"), Guid.Parse("4fc80be8-2867-4439-9db7-f31204e73344"), requiredLevel: 8);
            builder.GainAnySkillFeat(Guid.Parse("9e849925-5786-47ff-9049-16710ea3e085"), Guid.Parse("b0111733-1699-4543-add5-e7964db02fae"), requiredLevel: 9);
            builder.GainAnySkillFeat(Guid.Parse("de6c4d6d-962e-4321-9021-8b662cfd97cf"), Guid.Parse("efdc6489-1472-42bc-9c3a-01449ffacd9a"), requiredLevel: 10);
            builder.GainAnySkillFeat(Guid.Parse("325a344e-ed2c-4e90-8024-2b82ec35dd79"), Guid.Parse("d3d8e8b4-0920-4da1-a45a-17317d2ac3dd"), requiredLevel: 11);
            builder.GainAnySkillFeat(Guid.Parse("276e1b61-b691-47d5-882a-f2109b989e7b"), Guid.Parse("fa467d47-e9bf-47c2-8e06-abc6a6a60637"), requiredLevel: 12);
            builder.GainAnySkillFeat(Guid.Parse("0a95ee9f-3791-4802-a30f-55895dabf704"), Guid.Parse("60362c44-fc94-43b6-9bf2-7bf63023fef6"), requiredLevel: 13);
            builder.GainAnySkillFeat(Guid.Parse("3b884e6b-94ec-4a92-a240-29a36a08c4ff"), Guid.Parse("1b584aa5-121e-409c-abe9-af07b45d5a4e"), requiredLevel: 14);
            builder.GainAnySkillFeat(Guid.Parse("8883497c-acf1-4b68-8291-c53c65b3c87f"), Guid.Parse("28a47e52-337f-4409-ac6c-5750518ff350"), requiredLevel: 15);
            builder.GainAnySkillFeat(Guid.Parse("9439b594-9530-4238-8988-6f38270e4dda"), Guid.Parse("cd700c4c-5294-4738-9864-fd6ebacf2743"), requiredLevel: 16);
            builder.GainAnySkillFeat(Guid.Parse("e0d52555-0501-4561-8948-9c1df0292851"), Guid.Parse("8e731134-4920-4206-8f75-297d4096516e"), requiredLevel: 17);
            builder.GainAnySkillFeat(Guid.Parse("70283f8a-7a17-4eaf-9a2d-65992174350f"), Guid.Parse("8a9c80a2-9a45-429b-8dfe-535a7a8d6497"), requiredLevel: 18);
            builder.GainAnySkillFeat(Guid.Parse("319a181b-a6ed-4a01-9a7a-ceb0e5850bc9"), Guid.Parse("6155fb57-31f9-471a-8c53-0c770602a5d6"), requiredLevel: 19);
            builder.GainAnySkillFeat(Guid.Parse("5db19344-27f4-4780-9d1e-b01d2121e8ca"), Guid.Parse("60015476-d3e6-477b-b56a-fa6f18162f00"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("083224dd-77fe-4185-bb8b-625102947eef"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 181
            };
        }
    }
}
