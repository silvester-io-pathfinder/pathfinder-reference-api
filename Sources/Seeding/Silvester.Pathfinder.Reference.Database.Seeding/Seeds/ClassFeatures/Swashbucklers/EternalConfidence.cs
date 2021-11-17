using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Swashbucklers
{
    public class EternalConfidence : Template
    {
        public static readonly Guid ID = Guid.Parse("64baf272-c132-49ff-91a1-e740fab27893");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 19,
                Name = "Eternal Confidence", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("16d748d3-396d-47ad-b6b3-043b79cda3b7"), Type = TextBlockType.Text, Text = "As a swashbuckler at the peak of your skill, you swell with confidence and bravado in every attack. Your proficiency rank for your swashbuckler class DC increases to master." };
            yield return new TextBlock { Id = Guid.Parse("a69ddbaf-4290-4ca0-908b-76ab390eff4e"), Type = TextBlockType.Text, Text = "When you Strike as part of a finisher or Opportune Riposte, you can give the Strike the failure effect from the Confident Finisher action, including the increase from Precise Finisher if you have that feat. You can do so only if the Strike uses a weapon or unarmed attack that you could use for Confident Finisher." };

        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificClassDcProficiency(Guid.Parse("5d939655-7341-4d3b-a040-55508891bac4"), Proficiencies.Instances.Master.ID);
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("57ec4c4a-eabe-49f3-902f-0bbf615a2b25"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 87
            };
        }
    }
}
