using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemCurses
{
    public abstract class Template : EntityTemplate<ItemCurse>
    {
        protected override ItemCurse GetEntity(ModelBuilder builder)
        {
            ItemCurse itemCurse = GetItemCurse();

            builder.AddSourcePage(itemCurse, GetSourcePage(), e => e.SourcePageId);
            builder.AddTraits(itemCurse, GetTraits());
            builder.AddTextBlocks(itemCurse, GetDetailBlocks(), e => e.Details);
            
            return itemCurse;
        }

        public abstract ItemCurse GetItemCurse();
        public abstract SourcePage? GetSourcePage();
        public abstract IEnumerable<TextBlock> GetDetailBlocks();
        public abstract IEnumerable<Guid> GetTraits();
    }
}
