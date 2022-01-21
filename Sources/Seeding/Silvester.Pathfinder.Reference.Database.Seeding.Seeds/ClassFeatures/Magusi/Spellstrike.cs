using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Magusi
{
    public class Spellstrike : Template
    {
        public static readonly Guid ID = Guid.Parse("f739aa75-5e89-46e8-9948-b4b9a5251a89");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Spellstrike", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("dd7f0326-361c-4a3c-a1a5-0ecfb007ae72"), Type = TextBlockType.Text, Text = "You've learned the fundamental magus technique that lets you combine magical and physical attacks together. You gain the Spellstrike activity." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("729e70b3-8952-431f-b5d5-218eb5f60256"), Feats.Instances.Spellstrike.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("500acfb2-2dfd-47a5-87c4-fb7e798e5429"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 37
            };
        }
    }
}
