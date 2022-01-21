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

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.MeleeWeapons
{
    public abstract class Template : Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Template<MeleeWeapon, MeleeWeaponVariant>
    {
        protected override sealed MeleeWeapon GetItem()
        {
            return GetMeleeWeapon();
        }

        protected override sealed IEnumerable<MeleeWeaponVariant> GetVariants()
        {
            return GetMeleeWeaponVariants();
        }

        protected abstract IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants();
        protected abstract MeleeWeapon GetMeleeWeapon();
    }
}
