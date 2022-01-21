using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
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
                Failure = "The target becomes controlled by you and follows your orders. It (or the creature previously controlling it) can attempt a new Will save at the end of each of its turns, and the spell ends on a success. If you issue an obviously self-destructive order, the target doesn't act until you issue a new order.",
                CriticalFailure = "As failure, but the target (or the creature previously controlling it) receives a new save only if you give it a new order that is against its nature."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("e58ec16a-145d-4db9-9077-cb17dd705ea7"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("2193e3b1-1b02-4508-8484-534d802b1a5f"), Traits.Instances.Cursebound.ID);
            builder.Add(Guid.Parse("edce8b35-efe2-4277-a706-3f6840ddeb50"), Traits.Instances.Incapacitation.ID);
            builder.Add(Guid.Parse("495a81e6-0477-4cab-a309-2d937f2f7593"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("6afe5081-de19-45f4-95e2-dabb28badd56"), Traits.Instances.Oracle.ID);
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
