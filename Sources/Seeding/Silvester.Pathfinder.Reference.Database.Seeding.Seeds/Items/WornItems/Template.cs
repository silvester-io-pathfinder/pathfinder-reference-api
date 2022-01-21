using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WornItems
{
    public abstract class Template : Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Template<WornItem, WornItemVariant>
    {
        protected override sealed WornItem GetItem()
        {
            return GetWornItem();
        }

        protected override sealed IEnumerable<WornItemVariant> GetVariants()
        {
            return GetWornItemVariants();
        }

        protected abstract IEnumerable<WornItemVariant> GetWornItemVariants();
        protected abstract WornItem GetWornItem();
    }
}
