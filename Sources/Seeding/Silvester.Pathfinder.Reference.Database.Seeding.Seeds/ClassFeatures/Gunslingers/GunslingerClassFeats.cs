using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Gunslingers
{
    public class GunslingerClassFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("728497ca-47b9-4b86-92a0-e758913648a6");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Gunslinger Class Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f4056a63-ba8b-4d9b-9275-680559bcf907"), Type = TextBlockType.Text, Text = "At 1st level and every even-numbered level thereafter, you gain a gunslinger class feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyClassFeat(Guid.Parse("b75a8daf-90db-4912-ba22-e2bf7bc698aa"), Guid.Parse("6962d818-daaa-461e-aaf0-7e42ff76d6b2"), Classes.Instances.Gunslinger.ID, level: 1);
            builder.GainAnyClassFeat(Guid.Parse("6b593833-4ee4-454f-bbe7-3850e8c5281e"), Guid.Parse("73b9d210-153b-4b2b-8485-eb9e80b84b22"), Classes.Instances.Gunslinger.ID, level: 2);
            builder.GainAnyClassFeat(Guid.Parse("ff23fd80-ab4c-47f6-9bd3-2b2936544739"), Guid.Parse("adbab21a-8f4d-418a-a461-8ccf5e7b402d"), Classes.Instances.Gunslinger.ID, level: 4);
            builder.GainAnyClassFeat(Guid.Parse("6f466ae9-9731-4af2-b98e-23642da805ff"), Guid.Parse("0e09e8b0-d872-4b51-bac5-a5c6d15a8e89"), Classes.Instances.Gunslinger.ID, level: 6);
            builder.GainAnyClassFeat(Guid.Parse("5e98bb96-ad30-423a-bef6-bebbbc6758a9"), Guid.Parse("f4006f24-a02e-4986-b01c-278c853489c0"), Classes.Instances.Gunslinger.ID, level: 8);
            builder.GainAnyClassFeat(Guid.Parse("69eb45f1-7e30-48e6-9021-74b965a495cf"), Guid.Parse("678505a2-004b-4ed7-a08f-6f4f05d11c54"), Classes.Instances.Gunslinger.ID, level: 10);
            builder.GainAnyClassFeat(Guid.Parse("cde0f0a8-ad39-427a-a2a5-76d6540e9e33"), Guid.Parse("3d9267fb-98c8-4eec-b2ef-cd69dbc391bc"), Classes.Instances.Gunslinger.ID, level: 12);
            builder.GainAnyClassFeat(Guid.Parse("49bab558-976f-4db3-b7dd-f496cbbcc6e9"), Guid.Parse("0dc6e69a-8d80-493d-b331-0070e787cc88"), Classes.Instances.Gunslinger.ID, level: 14);
            builder.GainAnyClassFeat(Guid.Parse("26398bfd-d34e-412a-888a-23d708b6ca40"), Guid.Parse("c9726d76-46d0-4d86-a39d-1b85a23d8ac2"), Classes.Instances.Gunslinger.ID, level: 16);
            builder.GainAnyClassFeat(Guid.Parse("79f8e5c5-e5b2-421c-a1da-ac0257835604"), Guid.Parse("78ccd1fc-d468-409b-84e7-075a4f262057"), Classes.Instances.Gunslinger.ID, level: 18);
            builder.GainAnyClassFeat(Guid.Parse("e10cc952-cbc9-4e62-a548-83d44c826f5b"), Guid.Parse("7c6b6f80-cdf5-4755-b88e-d4beecf4d59f"), Classes.Instances.Gunslinger.ID, level: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("46cc0618-2330-4e5f-b56c-506e8fd5bc86"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 106
            };
        }
    }
}
