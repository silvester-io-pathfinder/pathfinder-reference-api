using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemCurses
{
    public abstract class AbstractItemCurseTemplate : EntityTemplate<ItemCurse>
    {
        protected override ItemCurse GetEntity(ModelBuilder builder)
        {
            ItemCurse itemCurse = GetItemCurse();

            SourcePage? sourcePage = GetSourcePage();
            if (sourcePage != null)
            {
                builder.AddData(sourcePage);
                itemCurse.SourcePageId = sourcePage.Id;
            }

            foreach (Guid traitId in GetTraits())
            {
                builder.HasJoinData<Trait, ItemCurse>((traitId, itemCurse.Id));
            }

            builder.AddTextBlocks(itemCurse, GetDetailBlocks(), e => e.Details);
            return itemCurse;
        }

        public abstract ItemCurse GetItemCurse();
        public abstract SourcePage? GetSourcePage();
        public abstract IEnumerable<TextBlock> GetDetailBlocks();
        public abstract IEnumerable<Guid> GetTraits();
    }
}
