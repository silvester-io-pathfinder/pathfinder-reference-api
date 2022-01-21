using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Magusi
{
    public class GeneralFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("8612f72e-2e44-4bfe-9048-f5b41fd95520");

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
            yield return new TextBlock { Id = Guid.Parse("3109545a-9dd6-47e1-842c-172e15ac5302"), Type = TextBlockType.Text, Text = "At 3rd level and every 4 levels thereafter, you gain a general feat. General feats are listed in Chapter 5." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyGeneralFeat(Guid.Parse("17c137f1-ac59-4b08-a1fe-317c44f421ff"), Guid.Parse("5389dbcb-416d-49de-b112-cc128a20dbf4"), requiredLevel: 3);
            builder.GainAnyGeneralFeat(Guid.Parse("9d00f619-ba31-4b32-80ef-627de9f74250"), Guid.Parse("654a58b3-fdf5-4e39-8d3f-605914089d3a"), requiredLevel: 7);
            builder.GainAnyGeneralFeat(Guid.Parse("54757ce0-28ee-457d-8412-6800df997eb6"), Guid.Parse("d0784101-f8bf-4d1e-909a-f2c81d25acb8"), requiredLevel: 11);
            builder.GainAnyGeneralFeat(Guid.Parse("1e6f4826-7957-4adb-a2d0-19e7c0b21067"), Guid.Parse("910a46c9-aebf-42f9-9b62-0c389824e987"), requiredLevel: 15);
            builder.GainAnyGeneralFeat(Guid.Parse("d77f6d36-77f2-48d2-92bd-b598a2f67d5f"), Guid.Parse("1da6b5ca-e1a4-4262-8eea-ab681d5e708b"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("93d661ed-6b8b-4d48-b2a6-8da1c56e3b1c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 40
            };
        }
    }
}
