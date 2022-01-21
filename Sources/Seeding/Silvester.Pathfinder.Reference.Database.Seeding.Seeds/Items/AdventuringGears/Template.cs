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

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears
{
    public abstract class Template : Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Template<AdventuringGear, AdventuringGearVariant>
    {
        protected override sealed AdventuringGear GetItem()
        {
            return GetAdventuringGear();
        }

        protected override sealed IEnumerable<AdventuringGearVariant> GetVariants()
        {
            return GetAdventuringGearVariants();
        }

        protected abstract IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants();
        protected abstract AdventuringGear GetAdventuringGear();
    }
}
