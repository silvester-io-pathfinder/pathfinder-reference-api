using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Builders.Tables
{
    public interface ITableBuilder
    {
        TableBuilder AddColumn(string id, string name);
        TableBuilder AddRow(string id, Action<RowBuilder> buildAction);
        TableBuilder Description(string description);
        Table Build();
    }

    public class TableBuilder : ITableBuilder
    {
        private Table Table { get; }

        public TableBuilder(string id, string? description = null)
            : this(Guid.Parse(id), description)
        {

        }

        public TableBuilder(Guid id, string? description = null)
        {
            Table = new Table
            {
                Id = id,
                Description = description,
                Columns = new List<Column>(),
                Rows = new List<Row>(),
            };
        }

        public TableBuilder Description(string description)
        {
            Table.Description = description;
            return this;
        }

        public TableBuilder AddColumn(string id, string name)
        {
            Table.Columns.Add(new Column { Id = Guid.Parse(id), Name = name, Order = Table.Columns.Count });
            return this;
        }

        public TableBuilder AddRow(string id, Action<RowBuilder> buildAction)
        {
            RowBuilder builder = new RowBuilder();
            buildAction(builder);
            Row row = builder.Build(id);
            row.Order = Table.Rows.Count;
            Table.Rows.Add(row);
            
            return this;
        }

        public Table Build()
        {
            return Table;
        }
    }

    public static class SeedBuilderExtensions
    {
        public static ISeedBuilder AddTable<TOwner>(this ISeedBuilder self, TOwner owner, Guid id, Action<ITableBuilder> buildAction, Expression<Func<TOwner, Guid?>> keySelector)
            where TOwner : BaseEntity
        {
            ITableBuilder builder = new TableBuilder(id);
            buildAction.Invoke(builder);

            return self.AddTable(owner, builder.Build(), keySelector);
        }

        public static ISeedBuilder AddTable<TOwner>(this ISeedBuilder self, TOwner owner, Table? table, Expression<Func<TOwner, Guid?>> keySelector)
            where TOwner : BaseEntity
        {
            if(table == null || table.Rows.Count == 0)
            {
                return self;
            }

            keySelector.SetProperty(owner, table.Id);
            table.OwnerId = owner.Id;
            self.AddData(table.GetType(), table);

            return self;
        }
    }
}
