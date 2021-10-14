using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions
{
    public abstract class Template : EntityTemplate<SkillAction>
    {
        protected override SkillAction GetEntity(ModelBuilder builder)
        {
            SkillAction action = GetSkillAction();

            builder.AddTraits(action, GetTraits());
            builder.AddTextBlocks(action, GetDetails(), e => e.Details);
            builder.AddRollableEffect(action, GetRollableEffect(), e => e.RollableEffect);
            builder.AddSourcePage(action, GetSourcePage(), e => e.SourcePageId);
            builder.AddTable(action, GetTable());

            foreach(Guid playModeId in GetRequiredPlayModes())
            {
                builder.HasJoinData<SkillAction, PlayMode>((action.Id, playModeId));
            }

            foreach(Guid skillId in GetApplicableSkills())
            {
                builder.HasJoinData<SkillAction, Skill>((action.Id, skillId));
            }

            foreach(SkillActionExample example in GetExamples())
            {
                example.SkillActionId = action.Id;
                builder.AddData(example);
            }

            return action;
        }

        protected abstract SkillAction GetSkillAction();
        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<TextBlock> GetDetails();
        protected abstract IEnumerable<Guid> GetApplicableSkills();

        protected virtual IEnumerable<Guid> GetTraits()
        {
            yield break;
        }

        protected virtual IEnumerable<Guid> GetRequiredPlayModes()
        {
            yield break;
        }

        protected virtual IEnumerable<SkillActionExample> GetExamples()
        {
            yield break;
        }

        protected virtual RollableEffect? GetRollableEffect()
        {
            return null;
        }

        protected virtual Table? GetTable()
        {
            return null;
        }
    }
}
