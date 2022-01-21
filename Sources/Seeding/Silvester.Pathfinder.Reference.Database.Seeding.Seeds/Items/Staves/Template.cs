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

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Staves
{
    public abstract class Template : Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Template<Stave, StaveVariant>
    {
        protected override sealed Stave GetItem()
        {
            return GetStave();
        }

        protected override sealed IEnumerable<StaveVariant> GetVariants()
        {
            return GetStaveVariants();
        }

        protected abstract IEnumerable<StaveVariant> GetStaveVariants();
        protected abstract Stave GetStave();
    }
}
