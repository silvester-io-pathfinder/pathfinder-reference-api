using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;

using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.GunslingersWays
{
    public abstract class Template : EntityTemplate<GunslingersWay>
    {
        protected override GunslingersWay GetEntity(ModelBuilder builder)
        {
            GunslingersWay way = GetGunslingersWay();

            builder.AddTextBlocks(way, GetDetails(), (e) => e.Details);
            builder.AddSourcePage(way, GetSourcePage(), (e => e.SourcePageId));
            builder.AddEffect(way, GetEffects, (way) => way.EffectId);
            builder.AddPrerequisite(way, GetPrerequisites);

            foreach(Guid skillId in GetWaySkills())
            {
                builder.HasJoinData<GunslingersWay, Skill>((way.Id, skillId));
            }

            return way;
        }

        protected abstract GunslingersWay GetGunslingersWay();
        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<Guid> GetWaySkills();
        protected abstract void GetEffects(BooleanEffectBuilder builder);
        protected abstract IEnumerable<TextBlock> GetDetails();

        protected virtual void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        {

        }
    }
}
