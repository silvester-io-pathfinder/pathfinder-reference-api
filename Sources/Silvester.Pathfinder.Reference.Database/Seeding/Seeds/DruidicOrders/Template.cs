using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DruidicOrders
{
    public abstract class Template : EntityTemplate<DruidicOrder>
    {
        protected override DruidicOrder GetEntity(ModelBuilder builder)
        {
            DruidicOrder order = GetDruidicOrder();

            builder.AddSourcePage(order, GetSourcePage(), (e => e.SourcePageId));
            builder.AddEffects(GetEffects(), (effect) => new DruidicOrderEffectBinding { DruidicOrderId = order.Id });

            return order;
        }

        protected abstract DruidicOrder GetDruidicOrder();
        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<Effect> GetEffects();
    }
}
