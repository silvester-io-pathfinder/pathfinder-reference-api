using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions
{
    public interface IInlineActionCollectionBuilder
    {
        InlineActionCollectionBuilder Add(Guid id, Guid actionTypeId, string name, Action<InlineActionBuilder> buildAction);
        List<InlineAction> Build();
    }

    public class InlineActionCollectionBuilder : IInlineActionCollectionBuilder
    {
        private IList<InlineActionBuilder> Builders { get; }

        public static implicit operator List<InlineAction>(InlineActionCollectionBuilder builder) => builder.Build();

        public InlineActionCollectionBuilder()
        {
            Builders = new List<InlineActionBuilder>();
        }

        public InlineActionCollectionBuilder Add(Guid id, Guid actionTypeId, string name, Action<InlineActionBuilder> buildAction)
        {
            InlineActionBuilder builder = new InlineActionBuilder(id, actionTypeId, name);
            buildAction.Invoke(builder);
            Builders.Add(builder);

            return this;
        }

        public List<InlineAction> Build()
        {
            return Builders
                .Select(e => e.Build())
                .ToList();
        }
    }

    public static partial class SeedBuilderExtensions
    {
        public static ISeedBuilder AddInlineActions<TOwner>(this ISeedBuilder self, TOwner owner, Action<InlineActionCollectionBuilder> buildAction)
            where TOwner : BaseEntity
        {
            InlineActionCollectionBuilder builder = new InlineActionCollectionBuilder();
            buildAction.Invoke(builder);
            self.AddInlineActions(owner, builder.Build());

            return self;
        }
    }
}
