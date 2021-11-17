using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Wizards
{
    public class WizardClassFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("b1337f38-3c77-445b-9495-8048512e755e");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 2,
                Name = "Wizard Class Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("56f36cb8-4aa5-4c9e-b1d6-c5938462e95e"), Type = TextBlockType.Text, Text = "At 2nd level and every even-numbered level thereafter, you gain a wizard class feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyClassFeat(Guid.Parse("b160675a-e3f9-41a5-9565-81c2456cd592"), Guid.Parse("8865602b-dd10-4bed-acd7-de5d93591c0c"), Classes.Instances.Wizard.ID, level: 2);
            builder.GainAnyClassFeat(Guid.Parse("36ebc600-9fbc-4218-8172-faf776d03cae"), Guid.Parse("e4000979-c82b-4898-b927-fc018d14e864"), Classes.Instances.Wizard.ID, level: 4);
            builder.GainAnyClassFeat(Guid.Parse("ee057573-0a5e-4006-a4a8-4cabed286f54"), Guid.Parse("6aa3759a-be76-4bf1-a997-5bc9dbb541ba"), Classes.Instances.Wizard.ID, level: 6);
            builder.GainAnyClassFeat(Guid.Parse("002280d3-4eb9-48e8-8439-144168f98dcd"), Guid.Parse("de989581-0c78-4058-bc78-5d7b84214852"), Classes.Instances.Wizard.ID, level: 8);
            builder.GainAnyClassFeat(Guid.Parse("14d5afdf-a48b-43fb-ab9c-f2d765890ffd"), Guid.Parse("a4fe536f-2347-40ee-91bc-b23a72024ab8"), Classes.Instances.Wizard.ID, level: 10);
            builder.GainAnyClassFeat(Guid.Parse("2b4a92dc-6ac6-49e8-8fd8-b9bb87492d0b"), Guid.Parse("44f706dc-e891-4be8-b34e-82013ad440b7"), Classes.Instances.Wizard.ID, level: 12);
            builder.GainAnyClassFeat(Guid.Parse("6998cfb0-7302-41bb-8007-e663e62f54bf"), Guid.Parse("e685d08d-249f-4abb-9fb8-a79ec5e0ad4d"), Classes.Instances.Wizard.ID, level: 14);
            builder.GainAnyClassFeat(Guid.Parse("e0a78853-dd94-430c-ada0-e61c256127b5"), Guid.Parse("ede6f1bc-15a9-47bd-8dca-7d66562a4c12"), Classes.Instances.Wizard.ID, level: 16);
            builder.GainAnyClassFeat(Guid.Parse("87f52729-3fe1-4b50-86a2-61a620a7f493"), Guid.Parse("8c050b8d-d1cb-4237-8324-d90741c611d9"), Classes.Instances.Wizard.ID, level: 18);
            builder.GainAnyClassFeat(Guid.Parse("2b24de98-4bb3-4750-8473-7d2afb3bfd96"), Guid.Parse("eea32af2-6eec-4d65-a4af-d9ed63b6ccbc"), Classes.Instances.Wizard.ID, level: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("75446261-a6fe-4f4d-8b40-683b533e020c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 206
            };
        }
    }
}
