using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Oracles
{
    public class GreaterResolve : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 17,
                Name = "Greater Resolve", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your unbelievable training grants you mental resiliency. Your proficiency rank for Will saves increases to legendary. When you roll a success on a Will save, you get a critical success instead. When you roll a critical failure on a Will save, you get a failure instead. When you fail a Will save against a damaging effect, you take half damage." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSavingThrowProficiency(Guid.Parse(""), Proficiencies.Instances.Legendary.ID, SavingThrowStats.Instances.Will.ID);
            builder.ImproveSpecificSavingThrow(Guid.Parse(""), SavingThrowStats.Instances.Will.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
            builder.ImproveSpecificSavingThrow(Guid.Parse(""), SavingThrowStats.Instances.Will.ID, RollResult.CriticalFailure, becomes: RollResult.Failure);
            //TODO: Add the half damage effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 72
            };
        }
    }
}
