using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.RollableEffects;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.StaggeredEffects;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions
{
    public interface IInlineActionBuilder
    {
        InlineActionBuilder ActionType(Guid actionTypeId);
        InlineAction Build();
        InlineActionBuilder Details(Action<TextBlockBuilder> buildAction);
        InlineActionBuilder Frequency(string frequency);
        InlineActionBuilder Kind(string kind);
        InlineActionBuilder Requirements(string requirements);
        InlineActionBuilder RollableEffect(Guid id, Action<RollableEffectBuilder> buildAction);
        InlineActionBuilder StaggeredEffect(Guid id, string name, string onset, Guid savingThrowStatId, string maximumDuration, Action<StaggeredEffectBuilder> buildAction);
        InlineActionBuilder Traits(Action<TraitBindingBuilder<InlineActionTraitBinding, InlineAction>> buildAction);
        InlineActionBuilder Trigger(string trigger);
    }

    public class InlineActionBuilder : IInlineActionBuilder
    {
        private InlineAction InlineAction { get; }

        public InlineActionBuilder(Guid id, Guid actionTypeId, string name)
        {
            InlineAction = new InlineAction
            {
                Id = id,
                Name = name,
                ActionTypeId = actionTypeId
            };
        }

        public InlineActionBuilder Requirements(string requirements)
        {
            InlineAction.Requirements = requirements;
            return this;
        }

        public InlineActionBuilder Kind(string kind)
        {
            InlineAction.Kind = kind;
            return this;
        }

        public InlineActionBuilder Trigger(string trigger)
        {
            InlineAction.Trigger = trigger;
            return this;
        }

        public InlineActionBuilder Frequency(string frequency)
        {
            InlineAction.Frequency = frequency;
            return this;
        }

        public InlineActionBuilder ActionType(Guid actionTypeId)
        {
            InlineAction.ActionTypeId = actionTypeId;
            return this;
        }

        public InlineActionBuilder Traits(Action<TraitBindingBuilder<InlineActionTraitBinding, InlineAction>> buildAction)
        {
            TraitBindingBuilder<InlineActionTraitBinding, InlineAction> builder = new(InlineAction.Id);
            buildAction.Invoke(builder);
            InlineAction.Traits = builder.Build();
            return this;
        }

        public InlineActionBuilder Details(Action<TextBlockBuilder> buildAction)
        {
            TextBlockBuilder builder = new();
            buildAction.Invoke(builder);
            InlineAction.Effect = builder.Build();
            return this;
        }

        public InlineActionBuilder RollableEffect(Guid id, Action<RollableEffectBuilder> buildAction)
        {
            RollableEffectBuilder builder = new(id);
            buildAction.Invoke(builder);
            InlineAction.RollableEffect = builder.Build();
            return this;
        }

        public InlineActionBuilder StaggeredEffect(Guid id, string name, string onset, Guid savingThrowStatId, string maximumDuration, Action<StaggeredEffectBuilder> buildAction)
        {
            StaggeredEffectBuilder builder = new(id, InlineAction.Id, name, onset, savingThrowStatId, maximumDuration);
            buildAction.Invoke(builder);
            InlineAction.StaggeredEffect = builder.Build();
            return this;
        }

        public InlineAction Build()
        {
            return InlineAction;
        }
    }

    public static partial class SeedBuilderExtensions
    {
        public static ISeedBuilder AddInlineActions<TOwner>(this ISeedBuilder self, TOwner owner, IEnumerable<InlineAction> actions)
               where TOwner : BaseEntity
        {
            foreach(InlineAction action in actions)
            {
                self.AddInlineAction(owner, action);
            }

            return self;
        }

        public static ISeedBuilder AddInlineAction<TOwner>(this ISeedBuilder self, TOwner owner, InlineAction action)
            where TOwner : BaseEntity
        {
            self.AddTextBlocks(action, action.Effect, e => e.Effect);

            action.Effect = new TextBlock[0];
            action.OwnerId = owner.Id;

            foreach (TraitBinding<InlineAction> binding in action.Traits)
            {
                binding.OwnerId = action.Id;
                self.AddData(binding.GetType(), binding);
            }
            action.Traits = new List<InlineActionTraitBinding>();

            if (action.RollableEffect != null)
            {
                self.AddRollableEffect(action, action.RollableEffect);
                action.RollableEffectId = action.RollableEffect.Id;
                action.RollableEffect = null;
            }

            self.AddData(action);

            return self;
        }
    }
}
