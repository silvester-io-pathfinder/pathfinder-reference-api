using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PreciousMaterialArmors
{
    public abstract class Template : EntityTemplate<PreciousMaterialArmor>
    {
        protected override PreciousMaterialArmor GetEntity(ModelBuilder builder)
        {
            PreciousMaterialArmor armor = GetArmor();

            builder.AddSourcePage(armor, GetSourcePage(), e => e.SourcePageId);
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
