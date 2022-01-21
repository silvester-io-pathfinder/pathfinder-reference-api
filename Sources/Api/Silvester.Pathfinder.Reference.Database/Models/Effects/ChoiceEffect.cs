
using Silvester.Pathfinder.Reference.Database.Models.Choices;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects
{
    public class ChoiceEffect : BaseEffect
    {
        public Guid ChoiceId { get; set; }
        public Choice Choice { get; set; } = default!;

        public ICollection<ChoiceEffectBinding> Entries { get; set; } = new List<ChoiceEffectBinding>();
    }

    public class ChoiceEffectBinding : BaseEntity
    {
        public Guid ChoiceEffectId { get; set; }
        public ChoiceEffect Choiceffect { get; set; } = default!;

        public Guid EffectId { get; set; }
        public BaseEffect Effect { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainChoice(this BooleanEffectBuilder builder, Guid id, Choice choice, ICollection<ChoiceEffectBinding> entries)
        {
            foreach(ChoiceEffectBinding binding in entries)
            {
                binding.ChoiceEffectId = id;
                binding.Id = binding.EffectId;
            }

            return builder.Add(new ChoiceEffect { Id = id, ChoiceId = choice.Id, Choice = choice, Entries = entries }) ;
        }
    }
}
