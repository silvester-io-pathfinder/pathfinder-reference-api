using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rogues
{
    public class RogueClassFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("a3f61fab-46a1-48f2-ac32-e28a8944bbe0");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Rogue Class Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8076db5b-b54d-4a6d-972c-ad959c90a52c"), Type = TextBlockType.Text, Text = "At 1st level and every even-numbered level, you gain a rogue class feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyClassFeat(Guid.Parse("abf0ac36-5e9b-46a2-9b3d-a4745f3cfb7e"), Classes.Instances.Rogue.ID, level: 1);
            builder.GainAnyClassFeat(Guid.Parse("21cb55f2-718d-400a-99ad-0679112e8ddd"), Guid.Parse("ed45467e-9018-40fb-ba5e-a8288c3116f4"), Classes.Instances.Rogue.ID, level: 2);
            builder.GainAnyClassFeat(Guid.Parse("d9256c87-efea-4b9d-a03f-c2d7e9b751b9"), Guid.Parse("1379634f-e18f-4dfd-991a-6254c6b85a93"), Classes.Instances.Rogue.ID, level: 4);
            builder.GainAnyClassFeat(Guid.Parse("12e049ee-33bf-4f72-965c-fa68da121eee"), Guid.Parse("b820126d-ae8e-4e86-99db-fbf91ea0cf18"), Classes.Instances.Rogue.ID, level: 6);
            builder.GainAnyClassFeat(Guid.Parse("4e2e40ed-d8ae-40b9-830e-78d1056ad97c"), Guid.Parse("407b6ba7-288d-472e-a2bc-f4259a53774a"), Classes.Instances.Rogue.ID, level: 8);
            builder.GainAnyClassFeat(Guid.Parse("cd1dd8c0-71d7-4dfb-9ae8-06f8d3332383"), Guid.Parse("79a26343-06c4-46c7-9996-29cf5ca70308"), Classes.Instances.Rogue.ID, level: 10);
            builder.GainAnyClassFeat(Guid.Parse("ac8f43dc-5197-47fb-91ce-7fa9e414a156"), Guid.Parse("2d238875-4b6e-4cfe-8c87-d6b4e70dafb9"), Classes.Instances.Rogue.ID, level: 12);
            builder.GainAnyClassFeat(Guid.Parse("63782458-a6d9-4b26-b33a-22282969d95d"), Guid.Parse("899086f8-0bcd-4fb3-9f88-3e8a628f93c3"), Classes.Instances.Rogue.ID, level: 14);
            builder.GainAnyClassFeat(Guid.Parse("ec75fc82-f404-4b68-be05-3f386fcc9efc"), Guid.Parse("24ed8eed-9ec3-415d-a7f7-85e7bfb67027"), Classes.Instances.Rogue.ID, level: 16);
            builder.GainAnyClassFeat(Guid.Parse("c8c2f9c0-ff08-43eb-ad8a-a03ebcaf0e77"), Guid.Parse("1ecb7f42-3b3b-4545-b497-d5291bdaf0d8"), Classes.Instances.Rogue.ID, level: 18);
            builder.GainAnyClassFeat(Guid.Parse("3facf1b0-71ae-4f6c-ae83-5212510425b7"), Guid.Parse("784a806d-28ae-490e-876b-f8912eaf805f"), Classes.Instances.Rogue.ID, level: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c396efdf-5d9e-400f-b77f-07240d2fa5c9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 181
            };
        }
    }
}
