using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Artifacts
{
    public abstract class Template : EntityTemplate<Artifact>
    {
        protected override Artifact GetEntity(ModelBuilder builder)
        {
            Artifact artifact = GetArtifact();

            builder.AddSourcePage(artifact, GetSourcePage(), e => e.SourcePageId);
            builder.AddTraits(artifact, GetTraits());
            builder.AddTextBlocks(artifact, GetDetails(), e => e.Details);

            foreach(ArtifactDestructionEffect effect in GetDestructionEffects())
            {
                effect.ArtifactId = artifact.Id;

                builder.HasJoinData<ArtifactDestructionEffect, Trait>(effect, GetDestructionEffectTraits(effect));
                builder.AddTextBlocks(effect, effect.Effects, e => e.Effects);

                effect.Effects = new TextBlock[0];

                builder.AddData(effect);
            }

            foreach (ArtifactAction action in GetActions())
            {
                action.ArtifactId = artifact.Id;

                builder.AddTextBlocks(action, action.Effects, e => e.Effects);
                builder.AddTraits(action, GetActionTraits(action));
                builder.AddRollableEffect(action, action.RollableEffect, e => e.RollableEffect);

                action.RollableEffect = null;
                action.Effects = new TextBlock[0];

                builder.AddData(action);
            }

            return artifact;
        }

        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract IEnumerable<TextBlock> GetDetails();
        protected abstract SourcePage GetSourcePage();
        protected abstract Artifact GetArtifact();

        protected virtual IEnumerable<ArtifactAction> GetActions()
        {
            yield break;
        }

        protected virtual IEnumerable<TextBlock> GetDestructionDetails()
        {
            yield break;
        }

        protected virtual IEnumerable<Guid> GetDestructionEffectTraits(ArtifactDestructionEffect effect)
        {
            yield break;
        }

        protected virtual IEnumerable<ArtifactDestructionEffect> GetDestructionEffects()
        {
            yield break;
        }

        protected virtual IEnumerable<Guid> GetActionTraits(ArtifactAction action)
        {
            yield break;
        }
    }
}
