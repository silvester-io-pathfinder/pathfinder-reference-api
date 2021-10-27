using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Witches
{
    public class GeneralFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "At 3rd level and every 4 levels thereafter, you gain a general feat. General feats are listed in Chapter 5." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyGeneralFeat(Guid.Parse(""), Guid.Parse(""), requiredLevel: 3);
            builder.GainAnyGeneralFeat(Guid.Parse(""), Guid.Parse(""), requiredLevel: 7);
            builder.GainAnyGeneralFeat(Guid.Parse(""), Guid.Parse(""), requiredLevel: 11);
            builder.GainAnyGeneralFeat(Guid.Parse(""), Guid.Parse(""), requiredLevel: 15);
            builder.GainAnyGeneralFeat(Guid.Parse(""), Guid.Parse(""), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 98
            };
        }
    }
}
