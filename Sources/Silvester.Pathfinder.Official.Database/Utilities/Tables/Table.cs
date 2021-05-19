using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Utilities.Tables
{
    public class Table : BaseEntity
    {
        public string? Description { get; set; }

        public ICollection<Column> Columns { get; set; } = new List<Column>();
        public ICollection<Row> Rows { get; set; } = new List<Row>();
    }

    public class Column : BaseEntity
    {
        public string Name { get; set; } = default!;

        public Guid TableId { get; set; }
        public Table Table { get; set; } = default!;
    }

    public class Row : BaseEntity
    {
        public Guid TableId { get; set; }
        public Table Table { get; set; } = default!;

        public ICollection<Cell> Cells { get; set; } = new List<Cell>();
    }

    public class Cell : BaseEntity
    {
        public string Value { get; set; } = default!;
        public int Order { get; set; }

        public Guid RowId { get; set; }
        public Row Row { get; set; } = default!;
    }

    public class TableBuilder
    {
        private IList<Column> Columns { get; }
        private IList<Row> Rows { get; }

        public TableBuilder()
        {
            Columns = new List<Column>();
            Rows = new List<Row>();
        }

        public TableBuilder AddColumn(string id, string name)
        {
            Columns.Add(new Column { Id = Guid.Parse(id), Name = name });
            return this;
        }

        public TableBuilder AddRow(string id, Action<RowBuilder> buildAction)
        {
            RowBuilder builder = new RowBuilder();
            buildAction(builder);
            Rows.Add(builder.Build(id));
            return this;
        }

        public Table Build(string id, string? description = null)
        {
            return new Table
            {
                Id = Guid.Parse(id),
                Columns = Columns,
                Rows = Rows,
                Description = description
            };
        }
    }

    public class RowBuilder
    {
        private IList<Cell> Cells { get; set; }

        public RowBuilder()
        {
            Cells = new List<Cell>();
        }

        public RowBuilder AddCell(string id, string value)
        {
            Cells.Add(new Cell { Id = Guid.Parse(id), Value = value });
            return this;
        }

        public Row Build(string id)
        {
            return new Row
            {
                Id = Guid.Parse(id),
                Cells = Cells
            };
        }
    }
}
