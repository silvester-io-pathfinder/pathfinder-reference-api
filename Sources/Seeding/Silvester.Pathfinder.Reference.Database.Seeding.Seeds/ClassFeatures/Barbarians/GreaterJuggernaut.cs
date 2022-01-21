using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Barbarians
{
    public class GreaterJuggernaut : Template
    {
        public static readonly Guid ID = Guid.Parse("e534887f-a30a-4362-9bf6-aea955c800f5");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 13,
                Name = "Greater Juggernaut", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("4c1b9b2c-0e00-4f94-be63-5a9e27897eb1"), Type = TextBlockType.Text, Text = "You have a stalwart physiology. Your proficiency rank for Fortitude saves increases to legendary. When you roll a critical failure on a Fortitude save, you get a failure instead. When you roll a failure on a Fortitude save against an effect that deals damage, you halve the damage you take." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("2566be3e-bb72-4d55-a77d-80421f33eb0d"), Proficiencies.Instances.Legendary.ID, SavingThrowStats.Instances.Fortitude.ID);
            builder.ImproveSpecificSavingThrow(Guid.Parse("efb773e8-6a5d-417c-bc82-29d1e899e75d"), SavingThrowStats.Instances.Fortitude.ID, RollResult.CriticalFailure, becomes: RollResult.Failure);
            //TODO: Add halving effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7359e083-aad0-479c-8926-cf0a4778b4b7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 85 
            };
        }
    }
}
