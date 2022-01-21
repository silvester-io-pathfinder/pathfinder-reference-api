using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Swashbucklers
{
    public class SwashbucklerClassFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("22746965-c0fc-457f-ba62-06849138b1d6");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Swashbuckler Class Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("9b44e4a2-c604-46e9-9fc9-f076b340559c"), Type = TextBlockType.Text, Text = "At 1st level and every even-numbered level thereafter, you gain a moswashbuckler class feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyClassFeat(Guid.Parse("c3296871-e5ab-4dc3-a53e-4221c48edd92"), Guid.Parse("ecf608af-a017-4c22-88d3-90283bb4869d"), Classes.Instances.Monk.ID, level: 1);
            builder.GainAnyClassFeat(Guid.Parse("7b83a656-b431-4b05-bdf3-2d3b5946c404"), Guid.Parse("829e8a59-425d-41ac-8dff-376afab1491c"), Classes.Instances.Monk.ID, level: 2);
            builder.GainAnyClassFeat(Guid.Parse("cbc988c0-21e0-4328-84fb-020189df5b9e"), Guid.Parse("97ec87e8-3008-405c-9932-0206e250d91e"), Classes.Instances.Monk.ID, level: 4);
            builder.GainAnyClassFeat(Guid.Parse("2674b601-0a23-4255-bcfe-cb60570d6068"), Guid.Parse("94b30cc5-5da3-468b-8fd9-6474effff78a"), Classes.Instances.Monk.ID, level: 6);
            builder.GainAnyClassFeat(Guid.Parse("8c9a481e-d809-4e0c-932a-ef4a1b728c06"), Guid.Parse("cf38cb87-c556-4f85-ac4a-76279207c7f8"), Classes.Instances.Monk.ID, level: 8);
            builder.GainAnyClassFeat(Guid.Parse("e0da50a5-349b-474c-be65-654232d1f162"), Guid.Parse("de85ad51-72c6-49bc-a0b4-af0d722f0aee"), Classes.Instances.Monk.ID, level: 10);
            builder.GainAnyClassFeat(Guid.Parse("a8a5715e-4f2b-4d4a-9553-6436f61230dc"), Guid.Parse("03a67478-8881-4005-a266-515b530b9038"), Classes.Instances.Monk.ID, level: 12);
            builder.GainAnyClassFeat(Guid.Parse("43244fe7-c890-48bc-ac88-ba067d699fa1"), Guid.Parse("f6b46ba3-e23c-4318-bf92-1c8a3e7a6b8b"), Classes.Instances.Monk.ID, level: 14);
            builder.GainAnyClassFeat(Guid.Parse("88590958-95d7-4a9c-affe-d442ffca5be1"), Guid.Parse("afc4916b-7c2e-4264-af28-a7a8e1f7bae8"), Classes.Instances.Monk.ID, level: 16);
            builder.GainAnyClassFeat(Guid.Parse("1e0561f2-72db-401f-b05a-0b560117efee"), Guid.Parse("dd480f86-3f77-4c00-ad89-d8bc021f8e4e"), Classes.Instances.Monk.ID, level: 18);
            builder.GainAnyClassFeat(Guid.Parse("b33c44db-e014-4067-93e5-d65b19cc62c7"), Guid.Parse("c62d9e75-fff7-4e3c-905d-e1359533e03a"), Classes.Instances.Monk.ID, level: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("27e80b31-2d85-4307-9d92-69d08695c519"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 85
            };
        }
    }
}
