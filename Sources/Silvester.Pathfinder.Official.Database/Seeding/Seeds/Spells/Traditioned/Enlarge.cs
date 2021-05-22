using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Enlarge : Template
    {
        public static readonly Guid ID = Guid.Parse("c2ee9ea9-0ebb-4fb3-9fde-c001f9a0f7ed");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Enlarge",
                Level = 2,
                Range = "30 feet.",
                Duration = "5 minutes.",
                Targets = "1 willing creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("94c569ee-eac6-4372-8788-7fa8f49a3602"), Type = TextBlockType.Text, Text = "Bolstered by magical power, the target grows to size Large. Its equipment grows with it but returns to natural size if removed. The creature is clumsy 1. Its reach increases by 5 feet (or by 10 feet if it started out Tiny), and it gains a +2 status bonus to melee damage. This spell has no effect on a Large or larger creature." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("73792167-2008-48a1-a913-0fe635703024"),
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("2e280524-2382-4125-b3e5-0f4d96124c62"), Type = TextBlockType.Text, Text = "The creature instead grows to size Huge. The status bonus to melee damage is +4 and the creature’s reach increases by 10 feet (or 15 feet if the creature started out Tiny). The spell has no effect on a Huge or larger creature." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("c2ec4149-7d96-4404-8ca8-a436b338f1ff"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("311c4505-5120-47d7-a12d-798a59fa2f5c"), Type = TextBlockType.Text, Text = "Choose either the 2nd-level or 4th-level version of this spell and apply its effects to up to 10 willing creatures." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Polymorph.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aaf7f980-ffe4-4129-aeed-9d2343f39f08"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 336
            };
        }
    }
}
