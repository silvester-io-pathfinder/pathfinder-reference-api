using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Druids
{
    public class AncestryAndBackground : Template
    {
        public static readonly Guid ID = Guid.Parse("a0e94ba5-68ad-41e1-80d2-b6e55919eb24");

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
            yield return new TextBlock { Id = Guid.Parse("6e39deb2-faf4-42ec-a3b7-52a76b69efeb"), Type = TextBlockType.Text, Text = "In addition to the abilities provided by your class at 1st level, you have the benefits of your selected ancestry and background, as described in Chapter 2 of the Core Rulebook." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyBackground(Guid.Parse("e9f0478c-a41b-4e63-8d23-c7ce258ef957"));
            builder.GainAnyAncestryFeat(Guid.Parse("f085cc51-6c27-4f5c-afa7-290b0a38327d"));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("527afc82-c1be-4f9c-95ba-0974d03e2044"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 130
            };
        }
    }
}
