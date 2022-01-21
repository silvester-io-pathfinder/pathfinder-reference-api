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

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AlchemicalPoisons
{
    public abstract class Template : Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Template<AlchemicalPoison, AlchemicalPoisonVariant>
    {
        protected override sealed AlchemicalPoison GetItem()
        {
            return GetAlchemicalPoison();
        }

        protected override sealed IEnumerable<AlchemicalPoisonVariant> GetVariants()
        {
            return GetAlchemicalPoisonVariants();
        }

        protected abstract IEnumerable<AlchemicalPoisonVariant> GetAlchemicalPoisonVariants();
        protected abstract AlchemicalPoison GetAlchemicalPoison();
    }
}
