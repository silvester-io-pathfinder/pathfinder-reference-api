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

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AlchemicalBombs
{
    public abstract class Template : Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Template<AlchemicalBomb, AlchemicalBombVariant>
    {
        protected override sealed AlchemicalBomb GetItem()
        {
            return GetAlchemicalBomb();
        }

        protected override sealed IEnumerable<AlchemicalBombVariant> GetVariants()
        {
            return GetAlchemicalBombVariants();
        }

        protected abstract IEnumerable<AlchemicalBombVariant> GetAlchemicalBombVariants();
        protected abstract AlchemicalBomb GetAlchemicalBomb();
    }
}
