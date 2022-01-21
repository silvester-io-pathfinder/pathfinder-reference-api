using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ShieldOther : Template
    {
        public static readonly Guid ID = Guid.Parse("41cdcd6c-9068-47d4-ad9b-889d7f0430f9");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shield Other",
                Level = 2,
                Range = "30 feet.",
                Duration = "10 minutes.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("985b5df8-c4e9-4878-b4e7-c37ce9453e10"), Type = TextBlockType.Text, Text = "You forge a temporary link between the target's life essence and your own. The target takes half damage from all effects that deal Hit Point damage, and you take the remainder of the damage. When you take damage through this link, you don't apply any resistances, weaknesses, or other abilities you have to that damage; you simply take that amount of damage. The spell ends if the target is ever more than 30 feet away from you. If either you or the target is reduced to 0 Hit Points, any damage from this spell is resolved and then the spell ends." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("7c1bd770-5f94-4ec2-8837-8b2c59df719d"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a299b4b1-6f6e-4ccc-b241-6c1e314e6e2d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 369
            };
        }
    }
}
