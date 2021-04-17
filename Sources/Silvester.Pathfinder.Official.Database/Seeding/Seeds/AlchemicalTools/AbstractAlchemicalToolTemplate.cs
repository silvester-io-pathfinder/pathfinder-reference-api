using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalTools
{
    public abstract class AbstractAlchemicalToolTemplate
    {
        public void Seed(AlchemicalToolSeeder seeder)
        {
            AlchemicalTool tool = GetAlchemicalTool(seeder);

            SourcePage? sourcePage = GetSourcePage(seeder);
            if (sourcePage != null)
            {
                seeder.Builder.AddData(sourcePage);
                tool.SourcePageId = sourcePage.Id;
            }

            foreach (AlchemicalToolDetailBlock detailBlock in GetDetailBlocks())
            {
                detailBlock.AlchemicalToolId = tool.Id;
                seeder.Builder.AddData(detailBlock);
            }

            foreach (AlchemicalToolPotencyBinding binding in GetPotencies(seeder))
            {
                binding.ToolId = tool.Id;
                seeder.Builder.AddData(binding);
            }

            foreach (Trait trait in seeder.FilterTraits(GetTraits().ToArray()))
            {
                seeder.Builder.HasJoinData((tool, trait));
            }

            seeder.Builder.AddData(tool);
        }

        protected abstract AlchemicalTool GetAlchemicalTool(AlchemicalToolSeeder seeder);
        protected abstract SourcePage? GetSourcePage(AlchemicalToolSeeder seeder);
        protected abstract IEnumerable<string> GetTraits();
        protected abstract IEnumerable<AlchemicalToolDetailBlock> GetDetailBlocks();
        
        protected virtual IEnumerable<AlchemicalToolPotencyBinding> GetPotencies(AlchemicalToolSeeder seeder)
        {
            yield break;
        }
    }
}
