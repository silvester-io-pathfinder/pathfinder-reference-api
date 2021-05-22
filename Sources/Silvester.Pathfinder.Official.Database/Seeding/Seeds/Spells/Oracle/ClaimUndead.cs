using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ClaimUndead : Template
    {
        public static readonly Guid ID = Guid.Parse("669facf8-143b-42c8-8ffe-07f6461fce0a");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Claim Undead",
                Level = 6,
                Range = "30 feet.",
                Targets = "1 undead creature.",
                Duration = "10 minutes.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Oracle.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
                MysteryId = Mysteries.Instances.Bones.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("21e99787-61af-442e-bb57-3d0d34854ccf"), Type = TextBlockType.Text, Text = "You attempt to wrest control of a target undead or force it to recognize you as its master. If the target is controlled by another creature, that controller attempts a Will saving throw to retain control; otherwise, the target must attempt a Will save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("4d991e1a-9a88-4e78-8f30-ee8dbcfbc38a"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is stunned 1 as it fights off your commands.",
                Failure = "The target becomes controlled by you and follows your orders. It (or the creature previously controlling it) can attempt a new Will save at the end of each of its turns, and the spell ends on a success. If you issue an obviously self-destructive order, the target doesn’t act until you issue a new order.",
                CriticalFailure = "As failure, but the target (or the creature previously controlling it) receives a new save only if you give it a new order that is against its nature."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cursebound.ID;
            yield return Traits.Instances.Incapacitation.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Oracle.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1bb48b37-c9ec-4201-afb2-23fa32f2d452"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 230
            };
        }
    }
}
