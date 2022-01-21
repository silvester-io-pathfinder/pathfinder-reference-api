using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Alchemists
{
    public class AlchemistClassFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("9271e94e-7bc6-4106-9a2e-7363c9ac347e");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID,
                Level = 1, 
                Name = "Alchemist Class Feats",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("5175c1dc-dc01-42e6-8069-c88e871034f7"), Type = TextBlockType.Text, Text = "At 1st level and every even-numbered level thereafter, you gain an alchemist class feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyClassFeat(Guid.Parse("92dbe3d2-6427-457d-abfa-42aa54a85833"), Guid.Parse("c658c5e5-5171-42b3-874b-44333b18835a"), Classes.Instances.Alchemist.ID, level: 1);
            builder.GainAnyClassFeat(Guid.Parse("4a87fbed-db27-443c-9f4a-d99fdb14c24c"), Guid.Parse("cb4d11b2-7aad-4de8-a2d7-7906b066fd11"), Classes.Instances.Alchemist.ID, level: 2);
            builder.GainAnyClassFeat(Guid.Parse("816e6b7b-4bb1-4776-a3dc-8978e5529f13"), Guid.Parse("04d91f76-43f6-4887-a388-8f84880d60f0"), Classes.Instances.Alchemist.ID, level: 4);
            builder.GainAnyClassFeat(Guid.Parse("de687ca4-92f4-4510-97a4-31a45f821dae"), Guid.Parse("37a682bf-92cf-4b0f-a0d1-89bf605966bf"), Classes.Instances.Alchemist.ID, level: 6);
            builder.GainAnyClassFeat(Guid.Parse("7a0b1770-58de-46c8-a580-7f0e36285d43"), Guid.Parse("bb907f58-6e42-4083-8327-11f067da56f9"), Classes.Instances.Alchemist.ID, level: 8);
            builder.GainAnyClassFeat(Guid.Parse("7509e4f0-72d3-4c63-873c-1ae0342a66da"), Guid.Parse("5b0b0e1e-3a6c-456c-9249-6b745e42df7d"), Classes.Instances.Alchemist.ID, level: 10);
            builder.GainAnyClassFeat(Guid.Parse("e6f546ef-f808-40ef-85d2-ae2a7331c79b"), Guid.Parse("74d33f4b-9bd3-403f-8983-0d3d67caf028"), Classes.Instances.Alchemist.ID, level: 12);
            builder.GainAnyClassFeat(Guid.Parse("03e715f9-a444-4f90-a57b-6accd592dfe3"), Guid.Parse("48087b96-d0ad-4dea-804f-8b28e063dcc4"), Classes.Instances.Alchemist.ID, level: 14);
            builder.GainAnyClassFeat(Guid.Parse("2fc99e5f-1ddf-42f2-910b-e56f4fe06965"), Guid.Parse("147cc2c2-de4e-4c24-8cf5-a4cded5ef6b4"), Classes.Instances.Alchemist.ID, level: 16);
            builder.GainAnyClassFeat(Guid.Parse("ec8fff2c-e0fb-4451-9efd-666899473b0f"), Guid.Parse("c2cbbcb9-24d6-4217-8c1e-1855854f9c4b"), Classes.Instances.Alchemist.ID, level: 18);
            builder.GainAnyClassFeat(Guid.Parse("1193a1a1-db62-4fab-9cc1-3c8c6b5bc643"), Guid.Parse("90fd6c65-e389-488c-a161-af0c04b61430"), Classes.Instances.Alchemist.ID, level: 20);
         }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4da6d9fd-12bb-49ac-a025-9d123871f876"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 73
            };
        }
    }
}
