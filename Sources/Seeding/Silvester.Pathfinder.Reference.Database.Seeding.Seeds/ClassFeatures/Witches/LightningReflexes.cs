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
    public class LightningReflexes : Template
    {
        public static readonly Guid ID = Guid.Parse("138ffa0d-35db-4eff-8e52-1f8cbb40211d");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 9,
                Name = "Lightning Reflexes", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("27294b5f-3cb8-4602-adb2-954fb5bf3bed"), Type = TextBlockType.Text, Text = "Your reflexes are lightning fast. Your proficiency rank for Reflex saves increases to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("2f7ac078-a462-4ed2-8897-ca7a965ed7ca"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Reflex.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a6b49a4f-d1b0-459f-9d5e-0cd28160b0d0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 98
            };
        }
    }
}
