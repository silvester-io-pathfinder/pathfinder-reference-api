using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalTools
{
    public abstract class Template : EntityTemplate<AlchemicalTool>
    {
        protected override AlchemicalTool GetEntity(ModelBuilder builder)
        {
            AlchemicalTool tool = GetAlchemicalTool();

            builder.AddSourcePage(tool, GetSourcePage(), e => e.SourcePageId);
            builder.AddTraits(tool, GetTraits());
            builder.AddTextBlocks(tool, GetDetailBlocks(), e => e.Details);

            foreach (AlchemicalToolPotencyBinding binding in GetPotencies())
            {
                binding.ToolId = tool.Id;
                builder.AddData(binding);
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
