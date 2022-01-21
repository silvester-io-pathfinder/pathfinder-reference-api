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

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AlchemicalElixirs
{
    public abstract class Template : Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Template<AlchemicalElixir, AlchemicalElixirVariant>
    {
        protected override sealed AlchemicalElixir GetItem()
        {
            return GetAlchemicalElixir();
        }

        protected override sealed IEnumerable<AlchemicalElixirVariant> GetVariants()
        {
            return GetAlchemicalElixirVariants();
        }

        protected abstract IEnumerable<AlchemicalElixirVariant> GetAlchemicalElixirVariants();
        protected abstract AlchemicalElixir GetAlchemicalElixir();
    }
}
