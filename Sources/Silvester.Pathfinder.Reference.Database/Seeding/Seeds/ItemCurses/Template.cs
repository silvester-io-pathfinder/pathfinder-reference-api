using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemCurses
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
