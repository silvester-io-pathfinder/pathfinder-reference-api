using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Clerics
{
    public class DruidicLanguage : Template
    {
        public static readonly Guid ID = Guid.Parse("a29093be-718a-4707-8097-9cf46563b4d1");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Druidic Language", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c821c70f-8cbf-4007-9f01-e69114d2aae5"), Type = TextBlockType.Text, Text = "You know Druidic, a secret language known to only druids, in addition to any languages you know through your ancestry. Druidic has its own alphabet. Teaching the Druidic language to non-druids is anathema." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificLanguage(Guid.Parse("4d5c80d4-c3dd-4c09-80e6-da30ff06a6f2"), Languages.Instances.Druidic.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7e3c51b3-148e-479c-b83f-3665033275dc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 130
            };
        }
    }
}
