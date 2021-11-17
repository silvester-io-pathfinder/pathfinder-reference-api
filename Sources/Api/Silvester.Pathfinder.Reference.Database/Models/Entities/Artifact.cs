using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Seeding;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{

    public class Artifact : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;
        
        public string? Destruction { get; set; }

        public string? Usage { get; set; }

        public int ItemLevel { get; set; }

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid? BulkId { get; set; }
        public Bulk? Bulk { get; set; } 

        public Guid? AlignmentId { get; set; }
        public Alignment? Alignment { get; set; } 

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
        
        public ICollection<Trait> Traits { get; set; } = new List<Trait>();

        public ICollection<ArtifactDestructionEffect> DestructionEffects { get; set; } = new List<ArtifactDestructionEffect>();

        public ICollection<ArtifactAction> Actions { get; set; } = new List<ArtifactAction>();
        
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class ArtifactAction : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string? Trigger { get; set; } 

        public string? Frequency { get; set; }

        public string? RequiredTime { get; set; }

        public string? Requirements { get; set; }

        public Guid ActionTypeId { get; set; }
        public ActionType ActionType { get; set; } = default!;

        public Guid ArtifactId { get; set; }
        public Artifact Artifact { get; set; } = default!;

        public Guid? RollableEffectId { get; set; }
        public RollableEffect? RollableEffect { get; set; }

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();
     
        public ICollection<TextBlock> Effects { get; set; } = new List<TextBlock>();

        public override bool Equals(object? obj)
        {
            return obj is ArtifactAction action &&
                   Id.Equals(action.Id) &&
                   Name == action.Name &&
                   Trigger == action.Trigger &&
                   Frequency == action.Frequency &&
                   RequiredTime == action.RequiredTime &&
                   Requirements == action.Requirements &&
                   ActionTypeId.Equals(action.ActionTypeId) &&
                   EqualityComparer<ActionType>.Default.Equals(ActionType, action.ActionType) &&
                   ArtifactId.Equals(action.ArtifactId) &&
                   EqualityComparer<Artifact>.Default.Equals(Artifact, action.Artifact) &&
                   EqualityComparer<Guid?>.Default.Equals(RollableEffectId, action.RollableEffectId) &&
                   EqualityComparer<RollableEffect?>.Default.Equals(RollableEffect, action.RollableEffect) &&
                   EqualityComparer<ICollection<Trait>>.Default.Equals(Traits, action.Traits) &&
                   EqualityComparer<ICollection<TextBlock>>.Default.Equals(Effects, action.Effects);
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(Name);
            hash.Add(Trigger);
            hash.Add(Frequency);
            hash.Add(RequiredTime);
            hash.Add(Requirements);
            hash.Add(ActionTypeId);
            hash.Add(ActionType);
            hash.Add(ArtifactId);
            hash.Add(Artifact);
            hash.Add(RollableEffectId);
            hash.Add(RollableEffect);
            hash.Add(Traits);
            hash.Add(Effects);
            return hash.ToHashCode();
        }
    }

    public class ArtifactDestructionEffect : BaseEntity
    {
        public string Name { get; set; } = default!;

        public Guid SavingThrowStatId { get; set; }
        public SavingThrowStat SavingThrowStat { get; set; } = default!;

        public int DifficultyCheck { get; set; }

        public Guid ArtifactId { get; set; }
        public Artifact Artifact { get; set; } = default!;

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();

        public ICollection<TextBlock> Effects { get; set; } = new List<TextBlock>();
    }

    public class ArtifactSearchConfigurator : SearchableEntityConfigurator<Artifact>
    {
        public override Expression<Func<Artifact, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Usage, e.Destruction };
        }
    }
}
