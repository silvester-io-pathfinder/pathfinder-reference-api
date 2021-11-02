﻿using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class ModifySpecificConditionEffect : BaseEffect
    {
        public Guid ConditionId { get; set; }
        public Condition Condition { get; set; } = default!;

        public int Modifier { get; set; }
        public ModifierType ModifierType { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder ModifySpecificCondition(this BooleanEffectBuilder builder, Guid id, Guid conditionId, ModifierType modifierType, int modifier)
        {
            return builder.Add(new ModifySpecificConditionEffect { Id = id, ConditionId = conditionId, ModifierType = modifierType, Modifier = modifier });
        }
    }
}