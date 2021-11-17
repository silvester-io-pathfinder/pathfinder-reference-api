using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Summoners
{
    public class AncestryFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("e5c14a29-f11c-464d-b32b-45035fbe3775");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 5,
                Name = "Ancestry Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("640cfe2e-f4b7-4bdf-9721-7bf763b4ce19"), Type = TextBlockType.Text, Text = "In addition to the ancestry feat you started with, you gain an ancestry feat at 5th level and every 4 levels thereafter." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAncestryFeat(Guid.Parse("47c42fc9-6960-4a5d-bb7f-86cfc46884ed"), Guid.Parse("4f804733-1e01-4887-b9b2-11a22f874abf"), requiredLevel: 5);
            builder.GainAnyAncestryFeat(Guid.Parse("52b9fe8e-d3f7-498e-974d-dd5d73788cba"), Guid.Parse("a6e023aa-8aed-43da-957c-925679c3d116"), requiredLevel: 9);
            builder.GainAnyAncestryFeat(Guid.Parse("432a454a-896e-4573-a0ae-53374b754a57"), Guid.Parse("6c856ac0-52d0-40e5-bf21-9f5ddecac300"), requiredLevel: 13);
            builder.GainAnyAncestryFeat(Guid.Parse("eafab169-0a2e-4044-9458-d782beb8ac87"), Guid.Parse("d9e495c5-c774-484f-92d9-5d576dc5ea88"), requiredLevel: 17);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1b8e87e4-939a-4cec-9120-c5dce7935742"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 56
            };
        }
    }
}
