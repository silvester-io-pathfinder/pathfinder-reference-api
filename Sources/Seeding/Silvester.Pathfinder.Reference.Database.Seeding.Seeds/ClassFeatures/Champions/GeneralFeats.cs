using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Champions
{
    public class GeneralFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("c26dfc9e-337e-4dd2-ad1f-dd8949fea04f");

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
            yield return new TextBlock { Id = Guid.Parse("74845169-97a8-4b01-a1b0-6ac63ff60f89"), Type = TextBlockType.Text, Text = "At 3rd level and every 4 levels thereafter, you gain a general feat. General feats are listed in Chapter 5." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyGeneralFeat(Guid.Parse("f5ae28cc-630b-4789-b657-394c81ae4295"), Guid.Parse("5e876313-3525-4a82-93c6-93eff004d012"), requiredLevel: 3);
            builder.GainAnyGeneralFeat(Guid.Parse("1e80fe30-ca29-4911-bedb-5eb58b96989b"), Guid.Parse("0c113802-9287-4744-bb6a-b0cb7a74f78a"), requiredLevel: 7);
            builder.GainAnyGeneralFeat(Guid.Parse("e7e7b8fb-093c-4dba-92f5-9fde68f298b8"), Guid.Parse("12d15f7f-ac94-43c9-badb-c93589794b41"), requiredLevel: 11);
            builder.GainAnyGeneralFeat(Guid.Parse("c69398bd-92c3-4c70-8800-69d386240387"), Guid.Parse("f6776579-a94b-4ee1-9891-778ac96383fd"), requiredLevel: 15);
            builder.GainAnyGeneralFeat(Guid.Parse("00c0d3e0-2bd7-4cda-8294-87e0c2daba45"), Guid.Parse("fb36be11-2937-4ff0-a2b5-fef5f3ab14f6"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("77565d85-b0fa-49b4-8e0f-2df23d46e9c0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 108
            };
        }
    }
}
