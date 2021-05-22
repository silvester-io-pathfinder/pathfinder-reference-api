using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PreciousMaterialShields
{
    public abstract class Template : EntityTemplate<PreciousMaterialShield>
    {
        protected override PreciousMaterialShield GetEntity(ModelBuilder builder)
        {
            PreciousMaterialShield weapon = GetShield();

            builder.AddSourcePage(weapon, GetSourcePage(), e => e.SourcePage);
            builder.AddTraits(weapon, GetTraits());
            builder.AddTextBlocks(weapon, GetDetails(), e => e.Details);

            foreach(PreciousMaterialShieldVariant variant in GetVariants())
            {
                variant.ShieldId = weapon.Id;
                builder.AddData(variant);
            }

            return weapon;
        }

        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract SourcePage GetSourcePage();
        protected abstract PreciousMaterialShield GetShield();
        protected abstract IEnumerable<PreciousMaterialShieldVariant> GetVariants();
        protected abstract IEnumerable<TextBlock> GetDetails();
    }
}
