using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PreciousMaterials
{
    public abstract class Template : EntityTemplate<PreciousMaterial>
    {
        protected override PreciousMaterial GetEntity(ModelBuilder builder)
        {
            PreciousMaterial material = GetMaterial();

            builder.AddSourcePage(material, GetSourcePage(), e => e.SourcePageId);
            builder.AddTraits(material, GetTraits());
            builder.AddTextBlocks(material, GetDetails(), e => e.Details);

            foreach (PreciousMaterialVariant variant in GetVariants())
            {
                variant.MaterialId = material.Id;
                builder.AddData(variant);
            }

            foreach (PreciousMaterialItem item in GetItems())
            {
                item.MaterialId = material.Id;
                builder.AddData(item);
            }

            return material;
        }

        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract PreciousMaterial GetMaterial();
        protected abstract IEnumerable<TextBlock> GetDetails();
        protected abstract IEnumerable<PreciousMaterialVariant> GetVariants();
        protected abstract IEnumerable<PreciousMaterialItem> GetItems();
    }
}
