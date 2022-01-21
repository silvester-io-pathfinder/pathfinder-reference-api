using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Magusi
{
    public class MagusClassFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("85f49165-e290-46b6-af6c-b5522f248031");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 2,
                Name = "Magus Class Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("488ff505-106a-4013-b37e-f970abebcf0a"), Type = TextBlockType.Text, Text = "At 2nd level and every even-numbered level thereafter, you gain a magus class feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyClassFeat(Guid.Parse("e578aeb8-fc0a-4827-9a9e-9ff21f51c25d"), Guid.Parse("0c3747ca-81a3-4bef-b324-caf0ab788dba"), Classes.Instances.Magus.ID, level: 2);
            builder.GainAnyClassFeat(Guid.Parse("22f9fb78-315b-4b5e-941d-ac6e3628a318"), Guid.Parse("5388209e-7a21-4ed2-9b32-e7017279bb08"), Classes.Instances.Magus.ID, level: 4);
            builder.GainAnyClassFeat(Guid.Parse("91279a00-d546-4db2-8baa-4f1f35210d1b"), Guid.Parse("f43a79aa-386b-406a-9e1b-dd93dc3b3652"), Classes.Instances.Magus.ID, level: 6);
            builder.GainAnyClassFeat(Guid.Parse("ed46f8c3-26c7-46fe-80b7-ad8b7a9ea171"), Guid.Parse("88cef9f1-c445-455a-b576-834624541f82"), Classes.Instances.Magus.ID, level: 8);
            builder.GainAnyClassFeat(Guid.Parse("6e980941-ad7e-4ee7-84db-bbfe40481edb"), Guid.Parse("8597c0ec-4318-46a6-b14c-8919eeb8a931"), Classes.Instances.Magus.ID, level: 10);
            builder.GainAnyClassFeat(Guid.Parse("10b46662-435c-47e8-8b0e-c37a4acf8162"), Guid.Parse("f14ea779-1061-48d8-82b7-338d93138dcc"), Classes.Instances.Magus.ID, level: 12);
            builder.GainAnyClassFeat(Guid.Parse("a202552e-a16e-4993-97ca-e5819f867b66"), Guid.Parse("97389a44-4514-47e4-828d-6e2c932579a6"), Classes.Instances.Magus.ID, level: 14);
            builder.GainAnyClassFeat(Guid.Parse("533d74b1-0dc8-452d-8e60-495179cbbb4f"), Guid.Parse("61c797bb-2b40-4043-977f-4cf717d276eb"), Classes.Instances.Magus.ID, level: 16);
            builder.GainAnyClassFeat(Guid.Parse("0a7407a2-a575-41b0-a1d8-c5809f47e95d"), Guid.Parse("33041fa6-3652-4cb5-96ad-586f9b1a41ec"), Classes.Instances.Magus.ID, level: 18);
            builder.GainAnyClassFeat(Guid.Parse("02619cdd-5054-4941-83d2-5fcdf8156b6f"), Guid.Parse("ec67a52c-48e1-4b4b-8bda-9d9add057b83"), Classes.Instances.Magus.ID, level: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4fe6de8f-1beb-4e8d-bde3-90ef28a9711f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 40
            };
        }
    }
}
