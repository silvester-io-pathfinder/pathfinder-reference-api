using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class CompelTrueName : Template
    {
        public static readonly Guid ID = Guid.Parse("ff53ddbd-65ef-4366-80e2-da15dc90b95f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Compel True Name",
                Level = 4,
                Range = "30 feet.",
                Targets = "1 creature whose true name you know.",
                Duration = "Varies",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7c48dd65-8572-4c2d-a7b0-f21e090dfb87"), Type = TextBlockType.Text, Text = "You instruct the target to do something, compelling obedience by calling it by its true name. Your instructions can�t be self-destructive. Though this spell has the linguistic trait, this applies only to the instructions; the creature doesn�t need to know its own true name to be affected. The target must attempt a Will saving throw." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("33acf478-c3c3-4096-b4ba-4ddb36627982"),
                CriticalSuccess = "The target is unaffected, is temporarily immune to further castings of this spell by you for 1 week, and learns your true name.",
                Success = "The target is unaffected, is temporarily immune to further castings of this spell by you for 1 day, and learns a fragment of your true name (see the Fragmentary Names sidebar at right).",
                Failure = "The target does as you command. The spell has a duration of 10 minutes, or until the target has completed a finite instruction or the instructions become selfdestructive. The creature is temporarily immune to further castings of this spell by you for 1 hour.",
                CriticalFailure = "As failure, but the spell�s duration is 8 hours, and the creature is not temporarily immune."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Auditory.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Incapacitation.ID;
            yield return Traits.Instances.Linguistic.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.TrueName.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bc7bcd60-bfcf-4ccc-ac8b-f65ca25d180b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 247
            };
        }
    }
}