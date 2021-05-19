using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Creatures
{
    public abstract class Template : EntityTemplate<Creature>
    {
        protected override Creature GetEntity(ModelBuilder builder)
        {
            Creature creature = GetCreature();

            SourcePage sourcePage = GetSourcePage();
            creature.SourcePageId = sourcePage.Id;
            builder.AddData(sourcePage);

            CreatureRecallKnowledge? recallKnowledge = GetRecallKnowledge();
            if(recallKnowledge != null)
            {
                recallKnowledge.CreatureId = creature.Id;
                builder.AddData(recallKnowledge);
            }

            builder.AddTextBlocks(creature, GetDetails(), e => e.Details);

            foreach (Guid traitId in GetTraits())
            {
                builder.HasJoinData<Creature, Trait>((creature.Id, traitId));
            }

            foreach (Guid languageId in GetLanguages())
            {
                builder.HasJoinData<Creature, Language>((creature.Id, languageId));
            }

            foreach (Guid immunityId in GetImmunities())
            {
                builder.HasJoinData<Creature, Immunity>((creature.Id, immunityId));
            }

            foreach(CreatureFlavor flavor in GetFlavors())
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

            foreach (CreatureAbility ability in GetAbilities())
            {
                ability.CreatureId = creature.Id;
                builder.AddData(ability);
            }

            return creature;
        }

        protected abstract IEnumerable<CreatureFlavor> GetFlavors();
        protected abstract IEnumerable<CreatureAbility> GetAbilities();
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
