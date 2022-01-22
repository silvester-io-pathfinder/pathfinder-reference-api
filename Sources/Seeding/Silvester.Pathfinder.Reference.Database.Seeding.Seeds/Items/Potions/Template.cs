using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Potions
{
    public abstract class Template : Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Template<Potion, PotionVariant>
    {
        protected override sealed Potion GetItem()
        {
            return GetPotion();
        }

        protected override sealed IEnumerable<PotionVariant> GetVariants()
        {
            return GetPotionVariants();
        }

        protected abstract IEnumerable<PotionVariant> GetPotionVariants();
        protected abstract Potion GetPotion();

    }
}
