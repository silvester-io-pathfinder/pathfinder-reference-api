using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.RollableEffects;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.StaggeredEffects;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineAttacks
{
    public interface IInlineAttackBuilder
    {
        InlineAttack Build();
        InlineAttackBuilder Details(Action<TextBlockBuilder> buildAction);
        InlineAttackBuilder StaggeredEffect(Guid id, string name, string onset, Guid savingThrowStatId, string maximumDuration, Action<StaggeredEffectBuilder> buildAction);
        InlineAttackBuilder Traits(Action<TraitBindingBuilder<InlineAttackTraitBinding, InlineAttack>> buildAction);
    }

    public class InlineAttackBuilder : IInlineAttackBuilder
    {
        private InlineAttack InlineAttack { get; }

        public InlineAttackBuilder(Guid id, Guid attackTypeId, Guid actionTypeId, string name, int hitModifier, string damage, Guid damageTypeId)
        {
            InlineAttack = new InlineAttack
            {
                AttackTypeId = attackTypeId,
                HitModifier = hitModifier,
                Damage = damage,
                DamageTypeId = damageTypeId,
                Id = id,
                Name = name,
                ActionTypeId = actionTypeId
            };
        }

        public InlineAttackBuilder Traits(Action<TraitBindingBuilder<InlineAttackTraitBinding, InlineAttack>> buildAction)
        {
            TraitBindingBuilder<InlineAttackTraitBinding, InlineAttack> builder = new(InlineAttack.Id);
            buildAction.Invoke(builder);
            InlineAttack.Traits = builder.Build();
            return this;
        }

        public InlineAttackBuilder Details(Action<TextBlockBuilder> buildAction)
        {
            TextBlockBuilder builder = new();
            buildAction.Invoke(builder);
            InlineAttack.Effect = builder.Build();
            return this;
        }

        public InlineAttackBuilder StaggeredEffect(Guid id, string name, string onset, Guid savingThrowStatId, string maximumDuration, Action<StaggeredEffectBuilder> buildAction)
        {
            StaggeredEffectBuilder builder = new(id, InlineAttack.Id, name, onset, savingThrowStatId, maximumDuration);
            buildAction.Invoke(builder);
            InlineAttack.StaggeredEffect = builder.Build();
            return this;
        }

        public InlineAttack Build()
        {
            return InlineAttack;
        }
    }

    public static partial class SeedBuilderExtensions
    {
        public static ISeedBuilder AddInlineAttacks<TOwner>(this ISeedBuilder self, TOwner owner, IEnumerable<InlineAttack> actions)
               where TOwner : BaseEntity
        {
            foreach(InlineAttack action in actions)
            {
                self.AddInlineAttack(owner, action);
            }

            return self;
        }

        public static ISeedBuilder AddInlineAttack<TOwner>(this ISeedBuilder self, TOwner owner, InlineAttack action)
            where TOwner : BaseEntity
        {
            self.AddTextBlocks(action, action.Effect, e => e.Effect);

            action.Effect = new TextBlock[0];
            action.OwnerId = owner.Id;

            foreach (TraitBinding<InlineAttack> binding in action.Traits)
            {
                binding.OwnerId = action.Id;
                self.AddData(binding.GetType(), binding);
            }
            action.Traits = new List<InlineAttackTraitBinding>();

            self.AddData(action);

            return self;
        }
    }
}
