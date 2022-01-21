using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Druids
{
    public class DruidClassFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("fbd1fb47-0422-4df6-ad3c-9be5073cb5a4");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 2,
                Name = "Druid Class Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("17c5b3da-71a1-42ea-9d91-33572d0f508a"), Type = TextBlockType.Text, Text = "At 2nd level and every even-numbered level thereafter, you gain a druid class feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyClassFeat(Guid.Parse("6199ecb1-ed4d-4406-9d0a-9d448b57694d"), Guid.Parse("cb6ec077-972b-4d15-84c3-0f4eff2d1ff5"), Classes.Instances.Druid.ID, level: 2);
            builder.GainAnyClassFeat(Guid.Parse("93b81dd3-13bc-4d28-8c5c-2cca934003a9"), Guid.Parse("4aa15ec1-eb95-44c3-8484-23294a18afa7"), Classes.Instances.Druid.ID, level: 4);
            builder.GainAnyClassFeat(Guid.Parse("e27b831b-dd64-4c6d-8ba4-dbbd3eedd74c"), Guid.Parse("43b5f455-6a0b-44c9-a4b4-d36d67b5babf"), Classes.Instances.Druid.ID, level: 6);
            builder.GainAnyClassFeat(Guid.Parse("6e7ba3d7-2237-4714-a2bb-4282a0f84b9a"), Guid.Parse("bc87b27a-07aa-4c84-be2e-1fa08e48be35"), Classes.Instances.Druid.ID, level: 8);
            builder.GainAnyClassFeat(Guid.Parse("e1ac710e-446f-41e0-ba1e-641c9dd45192"), Guid.Parse("4eb05aa1-b3cc-48dd-9372-4103807b06d1"), Classes.Instances.Druid.ID, level: 10);
            builder.GainAnyClassFeat(Guid.Parse("ad972ccc-271f-471e-b93d-65eb2671136a"), Guid.Parse("a4cade29-c4f0-49c4-ae51-8cc1fadc1e4f"), Classes.Instances.Druid.ID, level: 12);
            builder.GainAnyClassFeat(Guid.Parse("271de9d0-96f3-400c-b393-6ca80f9fdad8"), Guid.Parse("5e9d0601-3980-43bc-95d8-277f7912e4b2"), Classes.Instances.Druid.ID, level: 14);
            builder.GainAnyClassFeat(Guid.Parse("968db765-ffb6-4931-a09d-f6c2bba48607"), Guid.Parse("170ccac7-c747-4f36-943f-2841abcb18d8"), Classes.Instances.Druid.ID, level: 16);
            builder.GainAnyClassFeat(Guid.Parse("fbecfefd-4ee6-4d32-9182-a9b7613f741c"), Guid.Parse("3a1a3fe3-53ec-4c72-b806-54743196ae82"), Classes.Instances.Druid.ID, level: 18);
            builder.GainAnyClassFeat(Guid.Parse("f40a8064-a477-486b-8357-4cc0a0961ffa"), Guid.Parse("b00dd054-907d-4f4a-a483-e1d1c77b378f"), Classes.Instances.Druid.ID, level: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fc993b08-abe6-4ce8-a2f8-cff29759fdf3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 132
            };
        }
    }
}
