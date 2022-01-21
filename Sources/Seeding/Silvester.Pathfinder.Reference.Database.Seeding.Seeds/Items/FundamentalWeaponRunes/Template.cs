using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.FundamentalWeaponRunes
{
    public abstract class Template : Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Template<FundamentalWeaponRune, FundamentalWeaponRuneVariant>
    {
        protected override sealed FundamentalWeaponRune GetItem()
        {
            return GetFundamentalWeaponRune();
        }

        protected override sealed IEnumerable<FundamentalWeaponRuneVariant> GetVariants()
        {
            return GetFundamentalWeaponRuneVariants();
        }

        protected abstract IEnumerable<FundamentalWeaponRuneVariant> GetFundamentalWeaponRuneVariants();
        protected abstract FundamentalWeaponRune GetFundamentalWeaponRune();
    }
}
