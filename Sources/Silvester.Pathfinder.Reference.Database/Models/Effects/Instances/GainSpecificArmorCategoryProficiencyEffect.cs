using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class GainSpecificArmorCategoryProficiencyEffect : Effect
    {
        public Guid ArmorCategoryId { get; set; }
        public ArmorCategory ArmorCategory { get; set; } = default!;

        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;
    }

    public static partial class EffectCollectionBuilderExtensions
    {
        public static EffectCollectionBuilder<TConcrete, TBinding> GainSpecificArmorCategoryProficiency<TConcrete, TBinding>(this EffectCollectionBuilder<TConcrete, TBinding> builder, Guid bindingId, Guid id, Guid armorCategoryId, Guid proficiencyId, Action<EffectBuilder>? configureAction = null)
            where TConcrete : Effect, IEffectCollection<TBinding>
            where TBinding : BaseEffectBinding, new()
        {
            return builder.Add(bindingId, new GainSpecificArmorCategoryProficiencyEffect { Id = id, ArmorCategoryId = armorCategoryId, ProficiencyId = proficiencyId }, configureAction);
        }
    }
}
