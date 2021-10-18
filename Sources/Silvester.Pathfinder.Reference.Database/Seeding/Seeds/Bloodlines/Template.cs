using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bloodlines
{
    public abstract class Template : EntityTemplate<Bloodline>
    {
        protected override Bloodline GetEntity(ModelBuilder builder)
        {
            Bloodline bloodline = GetBloodline();

            builder.AddTextBlocks(bloodline, GetDetails(), (e) => e.Details);
            builder.AddTextBlocks(bloodline, GetTypeChoiceDetails(), (e) => e.TypeChoiceDetails);
            builder.AddSourcePage(bloodline, GetSourcePage(), (e => e.SourcePageId));
            builder.AddEffects(GetEffects(), (e) => new BloodlineEffectBinding { BloodlineId = bloodline.Id });

            foreach(Guid skillId in GetSkills())
            {
                builder.HasJoinData<Bloodline, Skill>((bloodline.Id, skillId));
            }

            return bloodline;
        }

        protected abstract Bloodline GetBloodline();
        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<Effect> GetEffects();
        protected abstract IEnumerable<TextBlock> GetDetails();
        protected abstract IEnumerable<Guid> GetSkills();
        
        protected virtual IEnumerable<TextBlock> GetTypeChoiceDetails()
        {
            yield break;
        }
    }
}
