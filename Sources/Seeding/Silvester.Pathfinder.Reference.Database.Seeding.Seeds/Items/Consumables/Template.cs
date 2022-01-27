using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Consumables
{
    public abstract class Template : Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Template<Consumable, ConsumableVariant>
    {
        protected override sealed Consumable GetItem()
        {
            return GetConsumable();
        }

        protected override sealed IEnumerable<ConsumableVariant> GetVariants()
        {
            return GetConsumableVariants();
        }

        protected abstract IEnumerable<ConsumableVariant> GetConsumableVariants();
        protected abstract Consumable GetConsumable();

    }
}
