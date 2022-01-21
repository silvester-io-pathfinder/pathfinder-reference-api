using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineAttacks
{
    public interface IInlineAttackCollectionBuilder
    {
        InlineAttackCollectionBuilder Add(Guid id, Guid attackTypeId, Guid actionTypeId, string name, int hitModifier, string damage, Guid damageTypeId, Action<InlineAttackBuilder>? buildAction = null);
        List<InlineAttack> Build();
    }

    public class InlineAttackCollectionBuilder : IInlineAttackCollectionBuilder
    {
        private IList<InlineAttackBuilder> Builders { get; }

        public static implicit operator List<InlineAttack>(InlineAttackCollectionBuilder builder) => builder.Build();

        public InlineAttackCollectionBuilder()
        {
            Builders = new List<InlineAttackBuilder>();
        }

        public InlineAttackCollectionBuilder Add(Guid id, Guid attackTypeId, Guid actionTypeId, string name, int hitModifier, string damage, Guid damageTypeId, Action<InlineAttackBuilder>? buildAction = null)
        {
            InlineAttackBuilder builder = new InlineAttackBuilder(id, attackTypeId, actionTypeId, name, hitModifier, damage, damageTypeId);
            buildAction?.Invoke(builder);
            Builders.Add(builder);

            return this;
        }

        public List<InlineAttack> Build()
        {
            return Builders
                .Select(e => e.Build())
                .ToList();
        }
    }

    public static partial class SeedBuilderExtensions
    {
        public static ISeedBuilder AddInlineAttacks<TOwner>(this ISeedBuilder self, TOwner owner, Action<InlineAttackCollectionBuilder> buildAction)
            where TOwner : BaseEntity
        {
            InlineAttackCollectionBuilder builder = new InlineAttackCollectionBuilder();
            buildAction.Invoke(builder);
            self.AddInlineAttacks(owner, builder.Build());

            return self;
        }
    }
}
