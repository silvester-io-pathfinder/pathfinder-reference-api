
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders
{
    public class BooleanPrerequisiteBuilder
    {
        private BooleanPrerequisite BooleanPrerequisite { get; }
        private IList<PrerequisiteBuilder> Entries { get; }

        public static implicit operator BasePrerequisite(BooleanPrerequisiteBuilder builder) => builder.Build();

        public static BooleanPrerequisiteBuilder CreateAnd(Guid id, Action<BooleanPrerequisiteBuilder>? buildAction = null)
        {
            BooleanPrerequisiteBuilder builder = new BooleanPrerequisiteBuilder(new BooleanPrerequisite { Id = id, Operator = BooleanOperator.And });
            buildAction?.Invoke(builder);
            return builder;
        }

        public static BooleanPrerequisiteBuilder CreateOr(Guid id, Action<BooleanPrerequisiteBuilder>? buildAction = null)
        {
            BooleanPrerequisiteBuilder builder = new BooleanPrerequisiteBuilder(new BooleanPrerequisite { Id = id, Operator = BooleanOperator.And });
            buildAction?.Invoke(builder);
            return builder;
        }

        public BooleanPrerequisiteBuilder(BooleanPrerequisite booleanPrerequisite)
        {
            BooleanPrerequisite = booleanPrerequisite;
            Entries = new List<PrerequisiteBuilder>();
        }

        public BooleanPrerequisiteBuilder AddAnd(Guid id, Action<BooleanPrerequisiteBuilder> buildAction)
        {
            return AddBoolean(CreateAnd(id), buildAction);
        }

        public BooleanPrerequisiteBuilder AddOr(Guid id, Action<BooleanPrerequisiteBuilder> buildAction)
        {
            return AddBoolean(CreateOr(id), buildAction);
        }

        private BooleanPrerequisiteBuilder AddBoolean(BooleanPrerequisiteBuilder subBuilder, Action<BooleanPrerequisiteBuilder> buildAction)
        {
            buildAction.Invoke(subBuilder);
            Add(subBuilder.Build());

            return this;
        }

        public PrerequisiteBuilder Add(BasePrerequisite effect)
        {
            PrerequisiteBuilder builder = new PrerequisiteBuilder(effect);
            Entries.Add(builder);
            return builder;
        }

        public BooleanPrerequisite Build()
        {
            foreach (PrerequisiteBuilder entry in Entries)
            {
                BasePrerequisite prerequisite = entry.Build();
                BooleanPrerequisite.Entries.Add(new BooleanPrerequisiteBinding { Id = prerequisite.Id, PrerequisiteId = prerequisite.Id, BooleanPrerequisiteId = BooleanPrerequisite.Id, Prerequisite = prerequisite });
            }

            return BooleanPrerequisite;
        }
    }

}
