using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Magusi
{
    public class AncestryAndBackground : Template
    {
        public static readonly Guid ID = Guid.Parse("d34e354a-bf73-4a27-ba75-8df461d15cfb");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Ancestry and Background", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8a64c74c-1461-4be8-b030-a41a71de1d15"), Type = TextBlockType.Text, Text = "In addition to the abilities provided by your class at 1st level, you have the benefits of your selected ancestry and background, as described in Chapter 2 of the Core Rulebook." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyBackground(Guid.Parse("3d6da804-6f7c-42d1-bfef-7f25be75deed"));
            builder.GainAnyAncestryFeat(Guid.Parse("4b14dd85-1424-4651-8484-46d40c20c72e"));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c37f592e-b6c2-45a9-ab6d-b459394f3547"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 36
            };
        }
    }
}
