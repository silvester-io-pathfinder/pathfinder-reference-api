using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Ammunitions
{
    public abstract class Template : Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Template<Ammunition, AmmunitionVariant>
    {
        protected override sealed Ammunition GetItem()
        {
            return GetAmmunition();
        }

        protected override sealed IEnumerable<AmmunitionVariant> GetVariants()
        {
            return GetAmmunitionVariants();
        }

        protected abstract IEnumerable<AmmunitionVariant> GetAmmunitionVariants();
        protected abstract Ammunition GetAmmunition();
    }
}
