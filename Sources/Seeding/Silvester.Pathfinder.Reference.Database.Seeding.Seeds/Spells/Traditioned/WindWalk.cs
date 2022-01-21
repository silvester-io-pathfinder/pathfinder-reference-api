using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class WindWalk : Template
    {
        public static readonly Guid ID = Guid.Parse("6d457742-ca7d-454c-8389-190800109e95");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Wind Walk",
                Level = 8,
                CastTime = "10 minutes.",
                Range = "Touch.",
                Duration = "8 hours.",
                Targets = "You and up to five creatures touched.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c8d2d31d-d086-42cf-8fe8-5c7a299cef8a"), Type = TextBlockType.Text, Text = "When you cast this spell, each target transforms into a vaguely cloud-like form and is picked up by a wind moving in the direction of your choice. You can change the wind's direction by using a single action, which has the concentrate trait. The wind carries the targets at a Speed of 20 miles per hour, but if any of the targets make an attack, Cast a Spell, come under attack, or otherwise enter encounter mode, the spell ends for all targets just after they roll initiative, and they drift gently to the ground." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("d9af3691-9681-4e79-ad88-c3af3aa5adf8"), Traits.Instances.Air.ID);
            builder.Add(Guid.Parse("b945b156-828a-4e5e-b501-57a5a9e64636"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a2cf6efe-2da5-40cc-9914-98a9f7ba55f5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 385
            };
        }
    }
}
