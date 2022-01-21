using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Summoners
{
    public class GeneralFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("87d21b24-0fe7-4de2-b3c3-0bc510a26f8f");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 3,
                Name = "General Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("04b30a2a-fec5-4a7f-8f1e-fb3c55ad8636"), Type = TextBlockType.Text, Text = "At 3rd level and every 4 levels thereafter, you gain a general feat. General feats are listed in Chapter 5." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyGeneralFeat(Guid.Parse("d4e6bdbf-8ff4-4ae4-ac48-487af22fe5cc"), Guid.Parse("748e6891-f5cd-48b8-9bfb-4c4db0d2291f"), requiredLevel: 3);
            builder.GainAnyGeneralFeat(Guid.Parse("a551a701-ff4e-4ae4-a819-59bab178caf2"), Guid.Parse("e6154a37-d6c3-41b7-ab06-57852b3acb54"), requiredLevel: 7);
            builder.GainAnyGeneralFeat(Guid.Parse("d08505b9-c1cf-4713-b18c-2ce302930646"), Guid.Parse("2ae05dcd-cac4-4467-9fec-acaaad882661"), requiredLevel: 11);
            builder.GainAnyGeneralFeat(Guid.Parse("73cf350b-882f-4726-bbaf-d380b2f5c44b"), Guid.Parse("579e6b8e-3e14-43b0-a6d1-a06420936bbf"), requiredLevel: 15);
            builder.GainAnyGeneralFeat(Guid.Parse("ab7bf1ec-9673-40e7-a131-09ae571efd54"), Guid.Parse("68d5d59a-3dd0-444e-a24e-bf02b2f15c6d"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("af38d62f-bf2b-493f-87a4-b8945a45e30f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 56
            };
        }
    }
}
