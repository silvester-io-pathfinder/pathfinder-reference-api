using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Repulsion : Template
    {
        public static readonly Guid ID = Guid.Parse("2e2c7320-6610-44fe-8e06-18950089fce1");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Repulsion",
                Level = 6,
                Range = "Emanation up to 40 feet.",
                Duration = "1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6385c041-a840-422c-b3d5-00a229fd7527"), Type = TextBlockType.Text, Text = "You manifest an aura that prevents creatures from approaching you. When casting the spell, you can make the area any radius you choose, up to 40 feet. A creature must attempt a Will save if it’s within the area when you cast the spell or as soon as it enters the area while the spell is in effect. Once a creature has attempted the save, it uses the same result for that casting of repulsion. Any restrictions on a creature’s movement apply only if it voluntarily moves toward you. For example, if you move closer to a creature, it doesn’t then need to move away." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("115958ba-5c52-463c-8a4d-3f27eb519e56"),
                CriticalSuccess = "The creature’s movement is not restricted.",
                Success = "The creature treats each square in the area as difficult terrain when moving closer to you.",
                Failure = "The creature can’t move closer to you within the area.",
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Aura.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a535c7c5-c85e-4e7a-8d6d-8a81f68f8741"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 363
            };
        }
    }
}
