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

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Armors
{
    public abstract class Template : Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Template<Armor, ArmorVariant>
    {
        protected override sealed Armor GetItem()
        {
            return GetArmor();
        }

        protected override sealed IEnumerable<ArmorVariant> GetVariants()
        {
            return GetArmorVariants();
        }

        protected abstract IEnumerable<ArmorVariant> GetArmorVariants();
        protected abstract Armor GetArmor();
    }
}
