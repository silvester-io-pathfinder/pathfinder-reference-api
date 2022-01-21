using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Rules
{
    public abstract class Template : EntityTemplate<Rule>
    {
        protected override Rule GetEntity(ISeedBuilder builder)
        {
            Rule rule = GetRule();

            builder.AddTextBlocks(rule, GetDetails(), (e) => e.Details);
            builder.AddSourcePage(rule, GetSourcePage(), (e => e.SourcePageId));

            return rule;
        }

        protected abstract Rule GetRule();
        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<TextBlock> GetDetails();
    }
}
