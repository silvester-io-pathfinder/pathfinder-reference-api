using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalElixirs
{
    public abstract class AbstractAlchemicalElixirTemplate
    {
        public void Seed(AlchemicalElixirSeeder seeder)
        {
            AlchemicalElixir elixir = GetAlchemicalElixir(seeder);

            SourcePage? sourcePage = GetSourcePage(seeder);
            if (sourcePage != null)
            {
                seeder.Builder.AddData(sourcePage);
                elixir.SourcePageId = sourcePage.Id;
            }

            TextBlock[] details = GetDetailBlocks().ToArray();
            for(int i = 0;i < details.Length; i ++)
            {
                TextBlock detail = details[i];
                detail.Order = i;
                detail.OwnerId = elixir.Id;
                seeder.Builder.AddOwnedData((AlchemicalElixir e) => e.Details, detail);
            }

            foreach (AlchemicalElixirPotencyBinding binding in GetPotencies(seeder))
            {
                binding.AlchemicalElixirId = elixir.Id;
                seeder.Builder.AddData(binding);
            }

            foreach (Trait trait in seeder.FilterTraits(GetTraits().ToArray()))
            {
                seeder.Builder.HasJoinData((elixir, trait));
            }

            foreach(AlchemicalElixirCraftingRequirement requirement in GetCraftingRequirements(seeder))
            {
                requirement.AlchemicalElixirId = elixir.Id;
                seeder.Builder.AddData(requirement);
            }

            seeder.Builder.AddData(elixir);
        }

        protected abstract AlchemicalElixir GetAlchemicalElixir(AlchemicalElixirSeeder seeder);
        protected abstract SourcePage? GetSourcePage(AlchemicalElixirSeeder seeder);
        protected abstract IEnumerable<string> GetTraits();
        protected abstract IEnumerable<TextBlock> GetDetailBlocks();
        protected abstract IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies(AlchemicalElixirSeeder seeder);

        protected virtual IEnumerable<AlchemicalElixirCraftingRequirement> GetCraftingRequirements(AlchemicalElixirSeeder seeder)
        {
            yield break;
        }
    }
}
