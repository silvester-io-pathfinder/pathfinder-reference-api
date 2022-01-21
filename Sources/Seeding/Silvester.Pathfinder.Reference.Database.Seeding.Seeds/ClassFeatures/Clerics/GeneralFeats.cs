using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Clerics
{
    public class GeneralFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("3c3df9db-f6d7-43a9-991d-2f5a6952c995");

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
            yield return new TextBlock { Id = Guid.Parse("e0e3ef05-e9ea-4cd8-adab-bde01e447124"), Type = TextBlockType.Text, Text = "At 3rd level and every 4 levels thereafter, you gain a general feat. General feats are listed in Chapter 5." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyGeneralFeat(Guid.Parse("b7a06c73-63b5-48ab-995e-baac241fecec"), Guid.Parse("3b9a9f8c-e5f9-49b1-b41f-b364ac4591ca"), requiredLevel: 3);
            builder.GainAnyGeneralFeat(Guid.Parse("22ba5786-ac8d-4894-978f-f862b64ddcf5"), Guid.Parse("1fec4253-2914-4b78-82f6-969768934930"), requiredLevel: 7);
            builder.GainAnyGeneralFeat(Guid.Parse("525733d3-0ba1-45fd-861d-2f20006fe82c"), Guid.Parse("5b20ab53-c063-41a6-a8e6-ac376a55930f"), requiredLevel: 11);
            builder.GainAnyGeneralFeat(Guid.Parse("13188330-6f39-4823-95c6-fe744b2ce10d"), Guid.Parse("bce45b8f-4fa0-4ef4-b5a0-5749f611de78"), requiredLevel: 15);
            builder.GainAnyGeneralFeat(Guid.Parse("a079a925-4e33-4a6f-9f7b-32246c9e6174"), Guid.Parse("167fab8e-e992-48ce-8971-efb724aad4ab"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ce637ba1-9453-4ebd-b98d-d42ed82310a5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 120
            };
        }
    }
}
