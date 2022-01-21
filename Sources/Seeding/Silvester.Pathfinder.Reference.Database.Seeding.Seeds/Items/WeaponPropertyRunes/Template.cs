using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WeaponPropertyRunes
{
    public abstract class Template : Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Template<WeaponPropertyRune, WeaponPropertyRuneVariant>
    {
        protected override sealed WeaponPropertyRune GetItem()
        {
            return GetWeaponPropertyRune();
        }

        protected override sealed IEnumerable<WeaponPropertyRuneVariant> GetVariants()
        {
            return GetWeaponPropertyRuneVariants();
        }

        protected abstract IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants();
        protected abstract WeaponPropertyRune GetWeaponPropertyRune();
    }
}
