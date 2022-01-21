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

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AlchemicalTools
{
    public abstract class Template : Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Template<AlchemicalTool, AlchemicalToolVariant>
    {
        protected override sealed AlchemicalTool GetItem()
        {
            return GetAlchemicalTool();
        }

        protected override sealed IEnumerable<AlchemicalToolVariant> GetVariants()
        {
            return GetAlchemicalToolVariants();
        }

        protected abstract IEnumerable<AlchemicalToolVariant> GetAlchemicalToolVariants();
        protected abstract AlchemicalTool GetAlchemicalTool();
    }
}
