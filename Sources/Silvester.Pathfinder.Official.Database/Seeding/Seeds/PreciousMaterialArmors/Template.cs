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

            foreach(Guid traitId in GetTraits())
            {
                builder.HasJoinData<PreciousMaterialArmor, Trait>((armor.Id, traitId));
            }

            builder.AddTextBlocks(armor, GetDetails(), e => e.Details);

            SourcePage sourcePage = GetSourcePage();
            armor.SourcePageId = sourcePage.Id;
            builder.AddData(sourcePage);

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
