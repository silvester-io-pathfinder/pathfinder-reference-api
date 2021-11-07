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
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You have a stalwart physiology. Your proficiency rank for Fortitude saves increases to legendary. When you roll a critical failure on a Fortitude save, you get a failure instead. When you roll a failure on a Fortitude save against an effect that deals damage, you halve the damage you take." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSavingThrowProficiency(Guid.Parse(""), Proficiencies.Instances.Legendary.ID, SavingThrowStats.Instances.Fortitude.ID);
            builder.ImproveSpecificSavingThrow(Guid.Parse(""), SavingThrowStats.Instances.Fortitude.ID, RollResult.CriticalFailure, becomes: RollResult.Failure);
            //TODO: Add halving effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 85 
            };
        }
    }
}
