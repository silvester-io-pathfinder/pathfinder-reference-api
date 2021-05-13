using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PreciousMaterials
{
    public abstract class Template : EntityTemplate<PreciousMaterial>
    {
        protected override PreciousMaterial GetEntity(ModelBuilder builder)
        {
            PreciousMaterial material = GetMaterial();

            builder.AddTextBlocks(material, GetDetails(), e => e.Details);

            SourcePage sourcePage = GetSourcePage();
            material.SourcePageId = sourcePage.Id;
            builder.AddData(sourcePage);

            foreach(Guid traitId in GetTraits())
            {
                builder.HasJoinData<PreciousMaterial, Trait>((material.Id, traitId));
            }

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
