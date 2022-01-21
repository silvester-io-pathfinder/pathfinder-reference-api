using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Wizards
{
    public class LightningReflexes : Template
    {
        public static readonly Guid ID = Guid.Parse("5af418af-2167-45e7-beef-0ab0ca2dce4b");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 5,
                Name = "Lightning Reflexes", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("65be0fa0-153d-4bc9-91c0-3a9b5e3a7708"), Type = TextBlockType.Text, Text = "Your reflexes are lightning fast. Your proficiency rank for Reflex saves increases to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("447f2fff-2c58-4119-b077-065bf6bc6a43"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Reflex.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7c1feb82-f04e-4397-aaeb-47743891705e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 207
            };
        }
    }
}
