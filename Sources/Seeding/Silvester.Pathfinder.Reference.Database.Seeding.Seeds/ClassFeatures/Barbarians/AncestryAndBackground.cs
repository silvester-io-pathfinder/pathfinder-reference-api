using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Barbarians
{
    public class AncestryAndBackground : Template
    {
        public static readonly Guid ID = Guid.Parse("ba8cb723-10df-4313-96a8-6322f1d1f394");

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
            yield return new TextBlock { Id = Guid.Parse("a54c987d-5888-440e-b69b-722c03299228"), Type = TextBlockType.Text, Text = "In addition to the abilities provided by your class at 1st level, you have the benefits of your selected ancestry and background, as described in Chapter 2 of the Core Rulebook." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyBackground(Guid.Parse("7f5239bd-1c36-4b06-a784-9e0dce4dadad"));
            builder.GainAnyAncestryFeat(Guid.Parse("4f46e040-a23e-4cd5-89e2-777e8c021878"));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1bb363d8-838f-48e9-b85b-76249d7f2a8f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 84
            };
        }
    }
}
