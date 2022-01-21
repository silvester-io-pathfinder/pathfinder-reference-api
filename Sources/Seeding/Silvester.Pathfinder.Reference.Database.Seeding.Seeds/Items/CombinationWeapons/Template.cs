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

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.CombinationWeapons
{
    public abstract class Template : Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Template<CombinationWeapon, CombinationWeaponVariant>
    {
        protected override sealed CombinationWeapon GetItem()
        {
            return GetCombinationWeapon();
        }

        protected override sealed IEnumerable<CombinationWeaponVariant> GetVariants()
        {
            foreach(CombinationWeaponVariant variant in GetCombinationWeaponVariants())
            {
                variant.MeleeComponentId = variant.MeleeComponent.Id;
                variant.RangedComponentId = variant.RangedComponent.Id;

                yield return variant;
            }
        }

        protected abstract IEnumerable<CombinationWeaponVariant> GetCombinationWeaponVariants();
        protected abstract CombinationWeapon GetCombinationWeapon();
    }
}
