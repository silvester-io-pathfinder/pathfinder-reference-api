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

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Shields
{
    public abstract class Template : Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Template<Shield, ShieldVariant>
    {
        protected override sealed Shield GetItem()
        {
            return GetShield();
        }

        protected override sealed IEnumerable<ShieldVariant> GetVariants()
        {
            return GetShieldVariants();
        }

        protected abstract IEnumerable<ShieldVariant> GetShieldVariants();
        protected abstract Shield GetShield();
    }
}
