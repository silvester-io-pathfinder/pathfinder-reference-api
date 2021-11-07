using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rangers
{
    public class ImprovedEvasion : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 15,
                Name = "Improved Evasion", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your ability to elude danger is matchless. Your proficiency rank for Reflex saves increases to legendary. When you roll a critical failure on a Reflex save, you get a failure instead. When you roll a failure on a Reflex save against a damaging effect, you take half damage." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSavingThrowProficiency(Guid.Parse(""), Proficiencies.Instances.Legendary.ID, SavingThrowStats.Instances.Reflex.ID);
            builder.ImproveSpecificSavingThrow(Guid.Parse(""), SavingThrowStats.Instances.Reflex.ID, RollResult.CriticalFailure, becomes: RollResult.Failure);
            //TODO: Add half damage effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 170
            };
        }
    }
}
