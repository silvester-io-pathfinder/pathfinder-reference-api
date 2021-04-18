using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemCurses
{
    public abstract class AbstractItemCurseTemplate
    {
        public void Seed(ItemCurseSeeder seeder)
        {
            ItemCurse itemCurse = GetItemCurse(seeder);

            SourcePage? sourcePage = GetSourcePage(seeder);
            if (sourcePage != null)
            {
                seeder.Builder.AddData(sourcePage);
                itemCurse.SourcePageId = sourcePage.Id;
            }

            foreach (Trait trait in seeder.FilterTraits(GetTraits().ToArray()))
            {
                seeder.Builder.HasJoinData((itemCurse, trait));
            }

            TextBlock[] details = GetDetailBlocks(seeder).ToArray();
            for (int i = 0; i < details.Length; i++)
            {
                TextBlock detail = details[i];
                detail.Order = i;
                detail.OwnerId = itemCurse.Id;
                seeder.Builder.AddOwnedData((ItemCurse f) => f.Details, detail);
            }

            seeder.Builder.AddData(itemCurse);
        }

        public abstract ItemCurse GetItemCurse(ItemCurseSeeder seeder);
        public abstract SourcePage? GetSourcePage(ItemCurseSeeder seeder);
        public abstract IEnumerable<TextBlock> GetDetailBlocks(ItemCurseSeeder seeder);
        public abstract IEnumerable<string> GetTraits();
    }
}
