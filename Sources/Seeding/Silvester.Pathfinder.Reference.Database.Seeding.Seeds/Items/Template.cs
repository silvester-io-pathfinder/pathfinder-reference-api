using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Tables;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items
{
    public abstract class Template<TItem, TVariant> : EntityTemplate<TItem>
        where TItem : BaseItem
        where TVariant : BaseItemVariant
    {
        protected override TItem GetEntity(ISeedBuilder builder)
        {
            TItem item = GetItem();

            builder.AddTextBlocks(item, GetDetails, e => e.Details);
            builder.AddTraitBindings<BaseItemTraitBinding, BaseItem>(item, GetTraits);
            builder.AddInlineActions(item, GetInlineActions);
            builder.AddSourcePage(item, GetSourcePage(), (e => e.SourcePageId));
            builder.AddTable(item, GetTable(), e => e.TableId);

            foreach(TVariant variant in GetVariants())
            {
                variant.ItemId = item.Id;
                builder.AddData(variant.GetType(), variant);
            }

            return item;
        }

        protected abstract TItem GetItem();
        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<TVariant> GetVariants();

        protected virtual void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {

        }

        protected virtual void GetDetails(ITextBlockBuilder builder)
        {

        }
        
        protected virtual void GetInlineActions(IInlineActionCollectionBuilder builder)
        {

        }

        protected virtual Table? GetTable()
        {
            return null;
        }
    }
}
