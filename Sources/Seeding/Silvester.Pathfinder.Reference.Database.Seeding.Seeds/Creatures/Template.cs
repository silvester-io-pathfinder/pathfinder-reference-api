using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Creatures
{
    public abstract class Template : EntityTemplate<Creature>
    {
        protected override Creature GetEntity(ISeedBuilder builder)
        {
            Creature creature = GetCreature();

            builder.AddSourcePage(creature, GetSourcePage(), e => e.SourcePageId);
            builder.AddTraits(creature, GetTraits());
            builder.AddTextBlocks(creature, GetDetails(), e => e.Details);

            CreatureRecallKnowledge? recallKnowledge = GetRecallKnowledge();
            if(recallKnowledge != null)
            {
                recallKnowledge.CreatureId = creature.Id;
                builder.AddData(recallKnowledge);
            }

            builder.AddJoinData<Creature, Language>(creature, GetLanguages());
            builder.AddJoinData<Creature, Immunity>(creature, GetImmunities());

            foreach (CreatureFlavor flavor in GetFlavors())
            {
                flavor.CreatureId = creature.Id;
                builder.AddTextBlocks(flavor, flavor.Details, e => e.Details);
                flavor.Details = new TextBlock[0];
                builder.AddData(flavor);
            }

            foreach (CreatureSkill skill in GetSkills())
            {
                skill.CreatureId = creature.Id;
                builder.AddData(skill);
            }

            foreach (CreatureSense ability in GetAbilities())
            {
                ability.CreatureId = creature.Id;
                builder.AddData(ability);
            }

            return creature;
        }

        protected abstract IEnumerable<CreatureFlavor> GetFlavors();
        protected abstract IEnumerable<CreatureSense> GetAbilities();
        protected abstract IEnumerable<CreatureSkill> GetSkills();
        protected abstract IEnumerable<Guid> GetImmunities();
        protected abstract IEnumerable<Guid> GetLanguages();
        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract IEnumerable<TextBlock> GetDetails();
        protected abstract SourcePage GetSourcePage();
        protected abstract Creature GetCreature();

        protected virtual CreatureRecallKnowledge? GetRecallKnowledge()
        {
            return null;
        }
    }
}
