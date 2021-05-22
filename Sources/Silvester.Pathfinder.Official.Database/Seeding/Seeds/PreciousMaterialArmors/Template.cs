using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PreciousMaterialArmors
{
    public abstract class Template : EntityTemplate<PreciousMaterialArmor>
    {
        protected override PreciousMaterialArmor GetEntity(ModelBuilder builder)
        {
            PreciousMaterialArmor armor = GetArmor();

            builder.AddSourcePage(armor, GetSourcePage(), e => e.SourcePage);
            builder.AddTraits(armor, GetTraits());
            builder.AddTextBlocks(armor, GetDetails(), e => e.Details);

            foreach(PreciousMaterialArmorVariant variant in GetVariants())
            {
                variant.ArmorId = armor.Id;
                builder.AddData(variant);
            }

            return armor;
        }

        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract SourcePage GetSourcePage();
        protected abstract PreciousMaterialArmor GetArmor();
        protected abstract IEnumerable<PreciousMaterialArmorVariant> GetVariants();
        protected abstract IEnumerable<TextBlock> GetDetails();
    }
}
