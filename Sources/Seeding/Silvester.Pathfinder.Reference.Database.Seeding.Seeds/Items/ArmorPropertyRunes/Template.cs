using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.ArmorPropertyRunes
{
    public abstract class Template : Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Template<ArmorPropertyRune, ArmorPropertyRuneVariant>
    {
        protected override sealed ArmorPropertyRune GetItem()
        {
            return GetArmorPropertyRune();
        }

        protected override sealed IEnumerable<ArmorPropertyRuneVariant> GetVariants()
        {
            return GetArmorPropertyRuneVariants();
        }

        protected abstract IEnumerable<ArmorPropertyRuneVariant> GetArmorPropertyRuneVariants();
        protected abstract ArmorPropertyRune GetArmorPropertyRune();
    }
}
