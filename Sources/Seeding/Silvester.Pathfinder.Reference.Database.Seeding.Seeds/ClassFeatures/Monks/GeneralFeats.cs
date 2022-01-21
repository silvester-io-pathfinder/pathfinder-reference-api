using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Monks
{
    public class GeneralFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("de3abad8-00b4-4acf-8d93-ea0e9ad64372");

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
            yield return new TextBlock { Id = Guid.Parse("5ec1fd46-d77d-4e42-ad96-d1098822f96b"), Type = TextBlockType.Text, Text = "At 3rd level and every 4 levels thereafter, you gain a general feat. General feats are listed in Chapter 5." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyGeneralFeat(Guid.Parse("5ff10638-a6e4-4ef5-8110-8afd794c6fa0"), Guid.Parse("0ebf723c-49df-47fc-a706-474602032486"), requiredLevel: 3);
            builder.GainAnyGeneralFeat(Guid.Parse("57ed8fd3-3e8d-4f25-bb74-eaad8045bb13"), Guid.Parse("747b8571-294e-491d-be97-dc09c7b0dc0c"), requiredLevel: 7);
            builder.GainAnyGeneralFeat(Guid.Parse("5c41a844-1125-4d7d-820c-dd380ec5a81d"), Guid.Parse("a9dcc348-180f-492d-a2bf-d38496333dae"), requiredLevel: 11);
            builder.GainAnyGeneralFeat(Guid.Parse("a00513d9-7d9e-48ed-954b-53af9c1811a1"), Guid.Parse("265709e4-defd-494f-8c93-adc46a265d14"), requiredLevel: 15);
            builder.GainAnyGeneralFeat(Guid.Parse("dc3a7944-b1bd-4847-8016-be61ac8a880b"), Guid.Parse("c3cc19a6-7c10-4366-88b3-73ed5747e2f8"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a4f467e4-d012-4362-af79-3e1b11b1977f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 156
            };
        }
    }
}
