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

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.MagicAmmunitions
{
    public abstract class Template : Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Template<MagicAmmunition, MagicAmmunitionVariant>
    {
        protected override MagicAmmunition GetEntity(ISeedBuilder builder)
        {
            MagicAmmunition magicAmmunition = base.GetEntity(builder);

            foreach (Guid ammunitionId in GetCraftableAs())
            {
                builder.AddJoinData<MagicAmmunition, Ammunition>(magicAmmunition, ammunitionId);
            }

            return magicAmmunition;
        }

        protected override sealed MagicAmmunition GetItem()
        {
            return GetMagicAmmunition();
        }

        protected override sealed IEnumerable<MagicAmmunitionVariant> GetVariants()
        {
            return GetMagicAmmunitionVariants();
        }

        protected abstract IEnumerable<MagicAmmunitionVariant> GetMagicAmmunitionVariants();
        protected abstract IEnumerable<Guid> GetCraftableAs();
        protected abstract MagicAmmunition GetMagicAmmunition();

    }
}
