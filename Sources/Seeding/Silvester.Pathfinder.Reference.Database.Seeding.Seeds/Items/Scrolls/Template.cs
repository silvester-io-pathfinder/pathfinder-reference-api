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

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Scrolls
{
    public abstract class Template : Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Template<Scroll, ScrollVariant>
    {
        protected override sealed Scroll GetItem()
        {
            return GetScroll();
        }

        protected override sealed IEnumerable<ScrollVariant> GetVariants()
        {
            return GetScrollVariants();
        }

        protected abstract IEnumerable<ScrollVariant> GetScrollVariants();
        protected abstract Scroll GetScroll();

    }
}
