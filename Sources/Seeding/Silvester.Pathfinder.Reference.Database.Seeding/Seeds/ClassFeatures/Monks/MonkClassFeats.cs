using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Monks
{
    public class MonkClassFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("7fcc68ae-337b-47d2-a050-4abaeba5e3dd");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Monk Class Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("6e5a5f0b-c2fb-489d-a320-c8212ecce3af"), Type = TextBlockType.Text, Text = "At 1st level and every even-numbered level thereafter, you gain a monk class feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyClassFeat(Guid.Parse("2020b8c5-96db-46f8-b609-0f77575ba8bd"), Guid.Parse("b260c4db-3478-47ad-b954-b14197f6f10d"), Classes.Instances.Monk.ID, level: 1);
            builder.GainAnyClassFeat(Guid.Parse("f257c7ab-1998-4c63-904d-dcc14142117c"), Guid.Parse("d0130415-7ddf-4f3c-aab1-57da46a7d14f"), Classes.Instances.Monk.ID, level: 2);
            builder.GainAnyClassFeat(Guid.Parse("bf14e62a-5627-4103-9466-f6795b0ad5a5"), Guid.Parse("44d41895-d08f-4181-8bd4-f1c55b324fd6"), Classes.Instances.Monk.ID, level: 4);
            builder.GainAnyClassFeat(Guid.Parse("3f3b19fd-960d-4443-bec2-cd769f466f1f"), Guid.Parse("93b56f61-d241-4a18-b31e-bf3083168d89"), Classes.Instances.Monk.ID, level: 6);
            builder.GainAnyClassFeat(Guid.Parse("bd6fc74c-63c0-4e12-a581-f4b5f7caef86"), Guid.Parse("026cac61-ee17-4143-be97-381ca33d6669"), Classes.Instances.Monk.ID, level: 8);
            builder.GainAnyClassFeat(Guid.Parse("3473bb6d-e120-4fee-a8e8-1bb4566102a6"), Guid.Parse("9fef71fe-e05d-412a-a56c-af3a8a339d98"), Classes.Instances.Monk.ID, level: 10);
            builder.GainAnyClassFeat(Guid.Parse("97c4835c-d467-4029-a076-e144c2e2d7b1"), Guid.Parse("331a9cee-a753-4792-b866-0f075b47a10e"), Classes.Instances.Monk.ID, level: 12);
            builder.GainAnyClassFeat(Guid.Parse("671f8531-eba5-4c4a-9431-e5091b1de07c"), Guid.Parse("9eba93d5-e1f5-4de2-bf4a-73e77a6471a0"), Classes.Instances.Monk.ID, level: 14);
            builder.GainAnyClassFeat(Guid.Parse("2fe01824-d37a-4693-a236-2150ca9e1d53"), Guid.Parse("3e8a2431-660c-4626-bd12-1c4dcfbc6bbd"), Classes.Instances.Monk.ID, level: 16);
            builder.GainAnyClassFeat(Guid.Parse("e01436c0-08e6-42b0-b44d-cf66f5cb038a"), Guid.Parse("f45cc204-0444-4f0a-a4ce-29809320f4c0"), Classes.Instances.Monk.ID, level: 18);
            builder.GainAnyClassFeat(Guid.Parse("6509065b-9209-4e57-9ae8-cd37c1b21f27"), Guid.Parse("c5f52d98-e938-477b-8eab-5bd9d96b3bda"), Classes.Instances.Monk.ID, level: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ca169dad-ae99-45ae-ba77-ad8371ebc998"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 156
            };
        }
    }
}
