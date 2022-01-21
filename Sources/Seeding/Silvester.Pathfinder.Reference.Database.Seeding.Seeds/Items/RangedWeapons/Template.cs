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

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.RangedWeapons
{
    public abstract class Template : Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Template<RangedWeapon, RangedWeaponVariant>
    {
        protected override sealed RangedWeapon GetItem()
        {
            return GetRangedWeapon();
        }

        protected override sealed IEnumerable<RangedWeaponVariant> GetVariants()
        {
            return GetRangedWeaponVariants();
        }

        protected abstract IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants();
        protected abstract RangedWeapon GetRangedWeapon();
    }
}
