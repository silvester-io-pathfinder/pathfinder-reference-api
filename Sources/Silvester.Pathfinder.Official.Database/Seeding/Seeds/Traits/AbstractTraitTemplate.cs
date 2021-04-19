using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits
{
    public abstract class AbstractTraitTemplate
    {
        public void Seed(TraitSeeder seeder)
        {
            Trait trait = GetTrait(seeder);

            TextBlock[] details = GetDetailBlocks().ToArray();
            for(int i = 0; i < details.Length; i ++)
            {
                TextBlock detail = details[i];
                detail.Order = i;
                detail.OwnerId = trait.Id;
                seeder.Builder.AddOwnedData((Trait e) => e.Details, detail);
            }

            SourcePage sourcePage = GetSourcePage();
            if (sourcePage != null)
            {
                seeder.Builder.AddData(sourcePage);
                trait.SourcePageId = sourcePage.Id;
            }

            seeder.Builder.AddData(trait);
        }

        protected abstract IEnumerable<TextBlock> GetDetailBlocks();
        protected abstract SourcePage GetSourcePage();
        protected abstract Trait GetTrait(TraitSeeder seeder);
    }
}
