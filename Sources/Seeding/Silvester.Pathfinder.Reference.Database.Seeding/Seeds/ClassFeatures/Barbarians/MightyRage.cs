using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Barbarians
{
    public class MightyRage : Template
    {
        public static readonly Guid ID = Guid.Parse("35284824-dd8a-4053-9949-684220b815ea");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 11,
                Name = "Mighty Rage", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("b81f4143-7dfe-49a5-b162-fca40d81e46c"), Type = TextBlockType.Text, Text = "Your rage intensifies and lets you burst into action. Your proficiency rank for your barbarian class DC increases to expert. You gain the Mighty Rage free action." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificClassDcProficiency(Guid.Parse("59a879e3-c647-4e5c-ae00-05393b096e1e"), Proficiencies.Instances.Expert.ID);
            builder.GainSpecificFeat(Guid.Parse("41155085-5e8c-4bfa-bf09-bd177a59c2f8"), Feats.Instances.MightyRage.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e7aa645e-e909-4c14-990f-7d71fb311f0a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 85
            };
        }
    }
}
