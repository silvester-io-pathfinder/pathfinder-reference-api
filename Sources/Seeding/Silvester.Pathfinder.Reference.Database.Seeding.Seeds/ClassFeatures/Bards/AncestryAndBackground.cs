using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Bards
{
    public class AncestryAndBackground : Template
    {
        public static readonly Guid ID = Guid.Parse("df096c61-7507-458c-9623-e9ff64a31829");

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
            yield return new TextBlock { Id = Guid.Parse("e43ef70d-c62d-401e-9d6e-c5ff3332149a"), Type = TextBlockType.Text, Text = "In addition to the abilities provided by your class at 1st level, you have the benefits of your selected ancestry and background, as described in Chapter 2 of the Core Rulebook." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyBackground(Guid.Parse("c78d2c57-fc13-4e65-ae49-3e532c14493b"));
            builder.GainAnyAncestryFeat(Guid.Parse("a88098d6-3a53-4638-ad15-f74961bb3511"));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("faf16294-928a-4bc6-a75f-63027b92b0a2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 96
            };
        }
    }
}
