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

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Talismans
{
    public abstract class Template : Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Template<Talisman, TalismanVariant>
    {
        protected override sealed Talisman GetItem()
        {
            return GetTalisman();
        }

        protected override sealed IEnumerable<TalismanVariant> GetVariants()
        {
            return GetTalismanVariants();
        }

        protected abstract IEnumerable<TalismanVariant> GetTalismanVariants();
        protected abstract Talisman GetTalisman();

    }
}
