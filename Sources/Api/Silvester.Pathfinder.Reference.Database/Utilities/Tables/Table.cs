using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Utilities.Tables
{
    public class Table : BaseEntity
    {
        public Guid OwnerId { get; set; }

        public string? Description { get; set; }

        public ICollection<Column> Columns { get; set; } = new List<Column>();
        public ICollection<Row> Rows { get; set; } = new List<Row>();
    }

    public class Column : BaseEntity
    {
        public Guid TableId { get; set; }
        public Table Table { get; set; } = default!;

        public string Name { get; set; } = default!;
        public int Order { get; set; } 
    }

    public class Row : BaseEntity
    {
        public Guid TableId { get; set; }
        public Table Table { get; set; } = default!;

        public int Order { get; set; } 
        public ICollection<Cell> Cells { get; set; } = new List<Cell>();
    }

    public class Cell : BaseEntity
    {
        public Guid RowId { get; set; }
        public Row Row { get; set; } = default!;

        public string Value { get; set; } = default!;
        public int Order { get; set; }
    }
}
