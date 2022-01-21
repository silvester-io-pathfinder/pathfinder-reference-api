using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.FundamentalArmorRunes
{
    public abstract class Template : Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Template<FundamentalArmorRune, FundamentalArmorRuneVariant>
    {
        protected override sealed FundamentalArmorRune GetItem()
        {
            return GetFundamentalArmorRune();
        }

        protected override sealed IEnumerable<FundamentalArmorRuneVariant> GetVariants()
        {
            return GetFundamentalArmorRuneVariants();
        }

        protected abstract IEnumerable<FundamentalArmorRuneVariant> GetFundamentalArmorRuneVariants();
        protected abstract FundamentalArmorRune GetFundamentalArmorRune();
    }
}
