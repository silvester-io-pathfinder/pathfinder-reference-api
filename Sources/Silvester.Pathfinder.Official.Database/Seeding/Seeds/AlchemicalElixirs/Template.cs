using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalElixirs
{
    public abstract class Template : EntityTemplate<AlchemicalElixir>
    {
        protected override AlchemicalElixir GetEntity(ModelBuilder builder)
        {
            AlchemicalElixir elixir = GetAlchemicalElixir();

            builder.AddTextBlocks(elixir, GetDetailBlocks(), e => e.Details);
            builder.AddSourcePage(elixir, GetSourcePage(), e => e.SourcePageId);
            builder.AddTraits(elixir, GetTraits());

            foreach (AlchemicalElixirPotencyBinding binding in GetPotencies())
            {
                binding.AlchemicalElixirId = elixir.Id;
                builder.AddData(binding);
            }

            foreach (AlchemicalElixirCraftingRequirement requirement in GetCraftingRequirements())
            {
                requirement.AlchemicalElixirId = elixir.Id;
                builder.AddData(requirement);
            }

            return elixir;
        }

        protected abstract AlchemicalElixir GetAlchemicalElixir();
        protected abstract SourcePage? GetSourcePage();
        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract IEnumerable<TextBlock> GetDetailBlocks();
        protected abstract IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies();

        protected virtual IEnumerable<AlchemicalElixirCraftingRequirement> GetCraftingRequirements()
        {
            yield break;
        }
    }
}
