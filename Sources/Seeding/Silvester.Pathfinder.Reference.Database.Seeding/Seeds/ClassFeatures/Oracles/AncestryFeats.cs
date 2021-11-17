using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Oracles
{
    public class AncestryFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("52bf6f85-3799-43c5-b49c-28cfec4c567d");

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
            yield return new TextBlock { Id = Guid.Parse("5b14f1be-7989-45b3-adce-6f5a061b21df"), Type = TextBlockType.Text, Text = "In addition to the ancestry feat you started with, you gain an ancestry feat at 5th level and every 4 levels thereafter." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAncestryFeat(Guid.Parse("8e394646-3b98-4504-849b-26ad8e0bd995"), Guid.Parse("555adf5e-82d0-4154-ada3-10098b6ca3a9"), requiredLevel: 5);
            builder.GainAnyAncestryFeat(Guid.Parse("b63bc08d-c19d-4c72-b77a-520b782b9e1b"), Guid.Parse("a153dd05-1a78-4c5b-a601-4aac9d486508"), requiredLevel: 9);
            builder.GainAnyAncestryFeat(Guid.Parse("6b4d26d7-2cc0-4c1d-8897-26c3828fab6f"), Guid.Parse("61774ca0-a670-45d3-ae0f-9e57c5520c52"), requiredLevel: 13);
            builder.GainAnyAncestryFeat(Guid.Parse("19615cf4-4ad5-469d-a6bc-625858a3b197"), Guid.Parse("ed44222a-0d0b-4f8d-aab0-4b00aca99825"), requiredLevel: 17);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0e6d1393-6bb4-4b41-846c-3a5424014aa6"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 71
            };
        }
    }
}
