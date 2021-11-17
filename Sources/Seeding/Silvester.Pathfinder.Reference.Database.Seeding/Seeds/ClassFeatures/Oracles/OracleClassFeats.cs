using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Oracles
{
    public class OraclesClassFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("3f51dff5-bcb8-4122-afe8-881fc9abef35");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 2,
                Name = "Oracles Class Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("6dc0f178-ef2c-4958-8308-1ed0ce1534bf"), Type = TextBlockType.Text, Text = "At 2nd level and every 2 levels thereafter, you gain a oracle class feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyClassFeat(Guid.Parse("f079aee8-e67c-4c74-bbe8-ff6f0a714a10"), Guid.Parse("29fcd85f-9147-4677-9886-7e4055602795"), Classes.Instances.Oracle.ID, level: 2);
            builder.GainAnyClassFeat(Guid.Parse("597a1e0a-57ea-4c88-84d1-019a914aa54d"), Guid.Parse("4c31aab9-dbc7-4114-842e-6484abafddf6"), Classes.Instances.Oracle.ID, level: 4);
            builder.GainAnyClassFeat(Guid.Parse("0ed071cf-ccc7-4ab5-bc19-9b73a626bb86"), Guid.Parse("9db1b19d-1797-43f2-bcdc-2f5171de0892"), Classes.Instances.Oracle.ID, level: 6);
            builder.GainAnyClassFeat(Guid.Parse("866a68f5-63ca-4c6c-957c-49ed4d1b3918"), Guid.Parse("633daa32-7b32-4076-a39c-8acb696277ab"), Classes.Instances.Oracle.ID, level: 8);
            builder.GainAnyClassFeat(Guid.Parse("bea19811-7a8a-4374-91ba-3136175409ce"), Guid.Parse("6db142bc-f9aa-45b7-8d45-ac352df4b3ae"), Classes.Instances.Oracle.ID, level: 10);
            builder.GainAnyClassFeat(Guid.Parse("03705b63-175a-4b71-bc7e-aff85af2dca1"), Guid.Parse("10ce05f9-f118-4c30-8221-1ea0262919d2"), Classes.Instances.Oracle.ID, level: 12);
            builder.GainAnyClassFeat(Guid.Parse("b6ace1c4-de68-4aa2-86f5-a88c59783d33"), Guid.Parse("501fb62c-a3e4-4979-99bf-a1f22152de69"), Classes.Instances.Oracle.ID, level: 14);
            builder.GainAnyClassFeat(Guid.Parse("f0882bb1-2eaa-40fe-b42d-53ce0001f4a4"), Guid.Parse("2dafa5f5-5cf2-442b-8898-cc31dfc2cf92"), Classes.Instances.Oracle.ID, level: 16);
            builder.GainAnyClassFeat(Guid.Parse("72298e4f-688d-49da-954f-2ac8bce9c73d"), Guid.Parse("cccaca63-a3fe-4c31-b4f2-7f4e40416ea1"), Classes.Instances.Oracle.ID, level: 18);
            builder.GainAnyClassFeat(Guid.Parse("d9b5059e-5b5d-4b50-aeb2-01dd022fec75"), Guid.Parse("af63da10-263d-45f8-ad67-245c02bb4555"), Classes.Instances.Oracle.ID, level: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d4d03005-bef1-4a47-9510-90b372ee2109"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 206
            };
        }
    }
}
