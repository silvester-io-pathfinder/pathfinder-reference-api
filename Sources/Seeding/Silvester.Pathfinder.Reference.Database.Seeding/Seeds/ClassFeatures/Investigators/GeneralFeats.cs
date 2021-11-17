using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Investigators
{
    public class GeneralFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("1fdf588b-d7aa-45c8-bf7b-53666d78f410");

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
            yield return new TextBlock { Id = Guid.Parse("01a2cd19-7cd1-476e-9f29-a338d3dc5405"), Type = TextBlockType.Text, Text = "At 3rd level and every 4 levels thereafter, you gain a general feat. General feats are listed in Chapter 5." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyGeneralFeat(Guid.Parse("fc17a5e1-8d8a-46f0-b63b-0c6a9b7a6502"), Guid.Parse("ec46c6ce-d375-43d5-b056-9e124f62e337"), requiredLevel: 3);
            builder.GainAnyGeneralFeat(Guid.Parse("b63ec632-7076-48bd-b079-b3d7df866818"), Guid.Parse("7eaddd47-dae9-43b3-b6f3-ec8a6e2561b4"), requiredLevel: 7);
            builder.GainAnyGeneralFeat(Guid.Parse("48ec051a-b34b-4a6b-9343-afe24995ca0e"), Guid.Parse("218b6c05-ed78-450d-821b-e6fb1c734b67"), requiredLevel: 11);
            builder.GainAnyGeneralFeat(Guid.Parse("70696f1d-e62a-4907-8eb5-d0d09c4ae0f5"), Guid.Parse("97dfa0ff-610d-48e4-b78c-0b4bc81aa09f"), requiredLevel: 15);
            builder.GainAnyGeneralFeat(Guid.Parse("08decc8f-b37c-4668-b8f5-97e374eb0fc7"), Guid.Parse("e2be10b2-9ade-4bb7-86f6-cdfd917bfbc8"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("17df4f83-ff49-4331-b657-a0842cbf41b1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 59
            };
        }
    }
}
