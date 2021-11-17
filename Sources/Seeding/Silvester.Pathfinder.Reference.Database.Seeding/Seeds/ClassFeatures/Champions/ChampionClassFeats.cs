using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Champions
{
    public class ChampionClassFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("a2af436c-af5d-45f6-9059-842df1b17e36");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Name = "Champion Class Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("48c4ea78-3902-4f7f-a43a-959c29e33bfb"), Type = TextBlockType.Text, Text = "At 1st level and every even-numbered level thereafter, you gain a champion class feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyClassFeat(Guid.Parse("1e8917bd-98bb-49e6-b8c9-662a8a22d186"), Guid.Parse("946c99ab-667b-46c3-b2b1-3a16b566c62d"), Classes.Instances.Champion.ID, level: 1);
            builder.GainAnyClassFeat(Guid.Parse("6ed9a54d-d48d-4d88-9c26-55930320f9ee"), Guid.Parse("625006e9-2c13-4525-a025-32df022fb184"), Classes.Instances.Champion.ID, level: 2);
            builder.GainAnyClassFeat(Guid.Parse("c07b556d-6937-4bcf-95be-70aa69bb2aaf"), Guid.Parse("eaa5c451-cad2-479b-898d-2374f302e076"), Classes.Instances.Champion.ID, level: 4);
            builder.GainAnyClassFeat(Guid.Parse("fe6c5ab7-2d2d-4b60-8982-cbd6c0cf787d"), Guid.Parse("ab0fe22f-0045-46a2-a472-4430c2db45ea"), Classes.Instances.Champion.ID, level: 6);
            builder.GainAnyClassFeat(Guid.Parse("edcb1af9-7b0c-4c06-b0a8-8aa433a629f7"), Guid.Parse("c837a23a-a701-4f06-acde-2f44df52ad0d"), Classes.Instances.Champion.ID, level: 8);
            builder.GainAnyClassFeat(Guid.Parse("2d907a79-e8b5-4aa5-89fb-c4f29fa817fc"), Guid.Parse("45a52c9a-662c-42d1-9895-95252184117e"), Classes.Instances.Champion.ID, level: 10);
            builder.GainAnyClassFeat(Guid.Parse("30b08378-ca01-4a2d-bca5-992b6c5adf0e"), Guid.Parse("b02287a7-3964-445f-8620-4a600f1a06cd"), Classes.Instances.Champion.ID, level: 12);
            builder.GainAnyClassFeat(Guid.Parse("2dd6e1e2-869a-4a7a-afe8-7fd242e0eae2"), Guid.Parse("65438fc0-29a1-4c06-93e4-c37f4c507d4b"), Classes.Instances.Champion.ID, level: 14);
            builder.GainAnyClassFeat(Guid.Parse("ae7ba975-7ef5-4834-9ebe-4f1d51b8eff9"), Guid.Parse("5c77de06-2919-4188-8c2c-9fd39320b4f2"), Classes.Instances.Champion.ID, level: 16);
            builder.GainAnyClassFeat(Guid.Parse("2e3d6cde-5919-4cac-8130-875cedc928b1"), Guid.Parse("c1ae6920-7f57-4a86-97a9-9bc91c8b5718"), Classes.Instances.Champion.ID, level: 18);
            builder.GainAnyClassFeat(Guid.Parse("1c5a475c-c21b-40b1-ae9a-727b53a35fb4"), Guid.Parse("0234e2bc-4324-4424-a403-41ce2d01c04e"), Classes.Instances.Champion.ID, level: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fa06162b-b6a7-46c7-82f7-860614f9ba21"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 108
            };
        }
    }
}
