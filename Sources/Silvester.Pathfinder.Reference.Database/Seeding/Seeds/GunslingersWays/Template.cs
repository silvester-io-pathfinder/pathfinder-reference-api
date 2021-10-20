using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.GunslingersWays
{
    public abstract class Template : EntityTemplate<GunslingersWay>
    {
        protected override GunslingersWay GetEntity(ModelBuilder builder)
        {
            GunslingersWay way = GetGunslingersWay();

            builder.AddTextBlocks(way, GetDetails(), (e) => e.Details);
            builder.AddSourcePage(way, GetSourcePage(), (e => e.SourcePageId));
            builder.AddEffects(GetEffects(), (effect) => new GunslingersWayEffectBinding { GunslingersWayId = way.Id });
            builder.AddPrerequisites(GetPrerequisites(), () => new GunslingersWayPrerequisiteBinding { GunslingersWayId = way.Id });

            foreach(Guid skillId in GetWaySkills())
            {
                builder.HasJoinData<GunslingersWay, Skill>((way.Id, skillId));
            }

            return way;
        }

        protected abstract GunslingersWay GetGunslingersWay();
        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<Guid> GetWaySkills();
        protected abstract IEnumerable<Effect> GetEffects();
        protected abstract IEnumerable<TextBlock> GetDetails();

        protected virtual IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield break;
        }
    }
}
