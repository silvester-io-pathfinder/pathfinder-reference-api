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

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.BeastGuns
{
    public abstract class Template : Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Template<BeastGun, BeastGunVariant>
    {
        protected override sealed BeastGun GetItem()
        {
            return GetBeastGun();
        }

        protected override sealed IEnumerable<BeastGunVariant> GetVariants()
        {
            return GetBeastGunVariants();
        }

        protected abstract IEnumerable<BeastGunVariant> GetBeastGunVariants();
        protected abstract BeastGun GetBeastGun();
    }
}
