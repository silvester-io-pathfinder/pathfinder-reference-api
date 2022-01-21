using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class InlineAttack : BaseEntity
    {
        public Guid OwnerId { get; set; }

        public string Name { get; set; } = default!;
        public int HitModifier { get; set; }
        public string Damage { get; set; } = default!;

        public Guid AttackTypeId { get; set; }
        public AttackType AttackType { get; set; } = default!;

        public Guid DamageTypeId { get; set; }
        public DamageType DamageType { get; set; } = default!;

        public Guid ActionTypeId { get; set; }
        public ActionType ActionType { get; set; } = default!;

        public Guid? StaggeredEffectId { get; set; }
        public StaggeredEffect? StaggeredEffect { get; set; }

        public ICollection<TextBlock> Effect { get; set; } = new List<TextBlock>();
        public ICollection<InlineAttackTraitBinding> Traits { get; set; } = new List<InlineAttackTraitBinding>();
    }

    public class InlineAttackTraitBinding : TraitBinding<InlineAttack>
    {

    }
}
