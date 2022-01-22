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

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.HeldItems
{
    public abstract class Template : Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Template<HeldItem, HeldItemVariant>
    {
        protected override sealed HeldItem GetItem()
        {
            return GetHeldItem();
        }

        protected override sealed IEnumerable<HeldItemVariant> GetVariants()
        {
            return GetHeldItemVariants();
        }

        protected abstract IEnumerable<HeldItemVariant> GetHeldItemVariants();
        protected abstract HeldItem GetHeldItem();
    }
}
