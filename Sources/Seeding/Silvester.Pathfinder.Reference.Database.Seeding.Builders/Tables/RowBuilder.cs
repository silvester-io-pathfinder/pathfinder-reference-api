using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Builders.Tables
{
    public interface IRowBuilder
    {
        RowBuilder AddCell(string id, string value);
        Row Build(string id);
    }

    public class RowBuilder : IRowBuilder
    {
        private IList<Cell> Cells { get; set; }

        public RowBuilder()
        {
            Cells = new List<Cell>();
        }

        public RowBuilder AddCell(string id, string value)
        {
            Cells.Add(new Cell { Id = Guid.Parse(id), Value = value, Order = Cells.Count });
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
