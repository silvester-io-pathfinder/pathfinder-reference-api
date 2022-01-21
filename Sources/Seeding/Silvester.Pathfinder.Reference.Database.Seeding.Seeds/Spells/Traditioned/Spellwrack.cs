using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Spellwrack : Template
    {
        public static readonly Guid ID = Guid.Parse("174f6b71-7b37-4563-8912-b13434bf930b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Spellwrack",
                Level = 6,
                Range = "30 feet.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4b24bcfe-ecbb-40c1-acb0-91d4e3aaf5b0"), Type = TextBlockType.Text, Text = "You cause any spells cast on the target to spill out their energy in harmful surges. The target must attempt a Will save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("01e10e04-f894-47fd-9d79-be3f58279db0"),
                CriticalSuccess = "The target is unaffected.",
                Success = "Whenever the target becomes affected by a spell with a duration, the target takes 2d12 persistent force damage. Each time it takes persistent force damage from spellwrack, it reduces the remaining duration of spells affecting it by 1 round. Only a successful Arcana check against your spell DC can help the target recover from the persistent damage; the curse and the persistent damage end after 1 minute.",
                Failure = "As success, but the curse and persistent damage do not end on their own.",
                CriticalFailure = "As failure, but the persistent force damage is 4d12."
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("88056cf6-be0d-4d91-924b-ddd869fd99d3"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("2c5a6264-0986-4a3d-9d05-405b2fc89b13"), Traits.Instances.Curse.ID);
            builder.Add(Guid.Parse("c2ff6f41-36fc-4122-869d-8a167c4d8433"), Traits.Instances.Force.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a960c420-68e0-44f1-8527-7024bf0f6f8f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 371
            };
        }
    }
}
