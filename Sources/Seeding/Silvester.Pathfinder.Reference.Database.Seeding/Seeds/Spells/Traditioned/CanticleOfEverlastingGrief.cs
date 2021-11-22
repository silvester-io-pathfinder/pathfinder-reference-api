using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class CanticleOfEverlastingGrief : Template
    {
        public static readonly Guid ID = Guid.Parse("0b266c2a-afde-488f-8c69-2178596b2daa");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Canticle of Everlasting Grief",
                Level = 8,
                Range = "120 feet.",
                Duration = "Varies.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2649d49a-febd-4b30-bbf8-bdb398738ab6"), Type = TextBlockType.Text, Text = "You create a melody distilled from pure grief, conveying the inevitable loss of everything your target cherishes, audible only to them. The target must attempt a Will save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("a8a60d81-2211-4f20-9c06-e693ca4f39a2"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes 5d6 mental damage, is frightened 1, and can�t benefit from circumstance or status bonuses for 1 round.",
                Failure = "The target takes 10d6 mental damage, is frightened 3, and can�t benefit from circumstance or status bonuses for 1 week.",
                CriticalFailure = "The target takes 20d6 mental damage and is frightened 4. It can�t benefit from circumstance or status bonuses until the curse is broken. While the curse remains, the target�s allies are also unable to benefit from circumstance or status bonuses while within 15 feet of it."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Auditory.ID;
            yield return Traits.Instances.Curse.ID;
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Fear.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c1c8c7cc-c0e0-4031-b308-558c96806fcf"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 94
            };
        }
    }
}
