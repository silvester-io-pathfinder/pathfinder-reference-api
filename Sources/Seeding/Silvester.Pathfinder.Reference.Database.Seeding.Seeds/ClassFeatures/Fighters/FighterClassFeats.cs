using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Fighters
{
    public class FighterClassFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("13b60957-5713-4fa6-af8e-684205d0da6e");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Fighter Class Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("9286401d-1fa3-4b54-9247-29c56e4e4e44"), Type = TextBlockType.Text, Text = "At 1st level and every even-numbered level thereafter, you gain a fighter class feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyClassFeat(Guid.Parse("88d45b51-95a3-46ed-a60d-1c2ea2bf5ec7"), Guid.Parse("7abefa4f-faa6-44b7-a6fb-a4dee256cc34"), Classes.Instances.Fighter.ID, level: 1);
            builder.GainAnyClassFeat(Guid.Parse("4de18568-da55-47ef-8f7a-d33582d68387"), Guid.Parse("d8068b35-8359-40f5-80e4-a00d1e1b1c98"), Classes.Instances.Fighter.ID, level: 2);
            builder.GainAnyClassFeat(Guid.Parse("dd2a6708-d690-4dcc-9ac6-4668374d13d5"), Guid.Parse("d059e823-4c81-4a73-b6d4-14b8adc0e6a5"), Classes.Instances.Fighter.ID, level: 4);
            builder.GainAnyClassFeat(Guid.Parse("dabd46f5-ad71-4191-91d3-82b4791cdea1"), Guid.Parse("75523def-295e-4540-bc3e-60d754af1517"), Classes.Instances.Fighter.ID, level: 6);
            builder.GainAnyClassFeat(Guid.Parse("7d93a539-3392-4cff-81be-ec92dc6ba890"), Guid.Parse("63fbcca0-9f5a-41f8-bb93-deb6cf06b2c0"), Classes.Instances.Fighter.ID, level: 8);
            builder.GainAnyClassFeat(Guid.Parse("19085890-2a83-438b-aae8-131da21c6867"), Guid.Parse("6b1eed0c-479f-4b62-8bf8-1f48af0e21e5"), Classes.Instances.Fighter.ID, level: 10);
            builder.GainAnyClassFeat(Guid.Parse("16a8989c-9e03-4669-ba5d-c044c54e00f1"), Guid.Parse("fb414c3f-c79f-41a1-80a0-e70093845354"), Classes.Instances.Fighter.ID, level: 12);
            builder.GainAnyClassFeat(Guid.Parse("92828167-4465-43b0-b0a7-6ebc65f22941"), Guid.Parse("7b798300-c02d-4ecd-91b1-effea4edc94e"), Classes.Instances.Fighter.ID, level: 14);
            builder.GainAnyClassFeat(Guid.Parse("35528a35-67fa-4bec-b885-8cad2d536efe"), Guid.Parse("0678454a-9e2a-40e7-a319-d475c2112dc4"), Classes.Instances.Fighter.ID, level: 16);
            builder.GainAnyClassFeat(Guid.Parse("f9a6e7f8-d7db-442e-ae3a-75e174e19690"), Guid.Parse("fc36e64e-aae1-4f4c-af04-d0ac1dad7bef"), Classes.Instances.Fighter.ID, level: 18);
            builder.GainAnyClassFeat(Guid.Parse("72557444-d495-437a-8e72-e07e08898fc5"), Guid.Parse("f2fdfd83-2117-4a7a-a66b-24e6bae1e6a4"), Classes.Instances.Fighter.ID, level: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6184e1e5-323c-416e-8ecf-ad27cda80c28"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 142
            };
        }
    }
}
