using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalTools
{
    public abstract class AbstractAlchemicalToolTemplate : EntityTemplate<AlchemicalTool>
    {
        protected override AlchemicalTool GetEntity(ModelBuilder builder)
        {
            AlchemicalTool tool = GetAlchemicalTool();

            SourcePage? sourcePage = GetSourcePage();
            if (sourcePage != null)
            {
                builder.AddData(sourcePage);
                tool.SourcePageId = sourcePage.Id;
            }

            builder.AddTextBlocks(tool, GetDetailBlocks(), e => e.Details);

            foreach (AlchemicalToolPotencyBinding binding in GetPotencies())
            {
                binding.ToolId = tool.Id;
                builder.AddData(binding);
            }

            foreach (Guid traitId in GetTraits())
            {
                builder.HasJoinData<Trait, AlchemicalTool>((traitId, tool.Id));
            }

            return tool;
        }

        protected abstract AlchemicalTool GetAlchemicalTool();
        protected abstract SourcePage? GetSourcePage();
        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract IEnumerable<TextBlock> GetDetailBlocks();
        
        protected virtual IEnumerable<AlchemicalToolPotencyBinding> GetPotencies()
        {
            yield break;
        }
    }
}
