using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits
{
    public interface ITraitBindingBuilder<TBinding, out TOwner>
        where TBinding : TraitBinding<TOwner>, new()
        where TOwner : BaseEntity
    {
        ITraitBindingBuilder<TBinding, TOwner> Add(Guid bindingId, Guid traitId, string? specifier = null);
        ICollection<TBinding> Build();
    }

    public class TraitBindingBuilder<TBinding, TOwner> : ITraitBindingBuilder<TBinding, TOwner>
        where TBinding : TraitBinding<TOwner>, new()
        where TOwner : BaseEntity
    {
        private List<TBinding> Bindings { get; }
        private Guid OwnerId { get; }

        public TraitBindingBuilder(Guid ownerId)
        {
            Bindings = new List<TBinding>();
            OwnerId = ownerId;
        }

        public ITraitBindingBuilder<TBinding, TOwner> Add(Guid bindingId, Guid traitId, string? specifier = null)
        {
            Bindings.Add(new TBinding
            {
                Id = bindingId,
                TraitId = traitId,
                OwnerId = OwnerId,
                Specifier = specifier
            });

            return this;
        }

        public ICollection<TBinding> Build()
        {
            return Bindings.AsReadOnly();
        }
    }

    public static class SeedBuilderExtensions
    {
        public static ISeedBuilder AddTraitBindings<TBinding, TOwner>(this ISeedBuilder self, TOwner owner, Action<ITraitBindingBuilder<TBinding, TOwner>> buildAction)
            where TBinding : TraitBinding<TOwner>, new()
            where TOwner : BaseEntity
        {
            ITraitBindingBuilder<TBinding, TOwner> builder = new TraitBindingBuilder<TBinding, TOwner>(owner.Id);
            buildAction.Invoke(builder);

            foreach(TBinding binding in builder.Build())
            {
                binding.OwnerId = owner.Id;
                self.AddData(binding);
            }

            return self;
        }
    }
}
