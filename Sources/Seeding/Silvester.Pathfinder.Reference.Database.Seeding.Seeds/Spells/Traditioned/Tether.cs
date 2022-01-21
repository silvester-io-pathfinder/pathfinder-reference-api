using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Tether : Template
    {
        public static readonly Guid ID = Guid.Parse("2c6d5090-e9be-42ad-8091-3d68118c8d99");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Tether",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature.",
                Duration = "1 minute or until dismissed.",
                IsDismissable = true,
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0e6867ca-d297-4e2a-8ca8-de81480a977d"), Type = TextBlockType.Text, Text = "You use magical chains, vines, or other tethers to bind your target to you. The creature can still try to Escape, and it or others can break the tethers by attacking them (the tethers have AC 15 and 10 Hit Points). You must stay within 30 feet of the target while it is tethered; moving more than 30 feet away from your target ends the spell. The target must attempt a Reflex save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("fcb1db47-835b-400c-b00e-aadf95b6bb3d"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("cad31ffe-8901-489a-a1fd-994887a8c5f8"), Type = TextBlockType.Text, Text = "The tethers' AC increases by 3 and their Hit Points increase by 10." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("acc05e91-373d-44f9-87ed-c39d9b091d45"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes a �5-foot circumstance penalty to its Speed as long as it is within 30 feet of you.",
                Failure = "The target takes a �10-foot circumstance penalty to its Speed and cannot move more than 30 feet away from you until it Escapes or the spell ends.",
                CriticalFailure = "The target is immobilized until it Escapes or the spell ends."
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("4aae6998-4192-4145-9b2d-1045f2b68cb5"), Traits.Instances.Abjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f6eb127e-aa5f-46ad-a0b2-b2fa8f16a9f5"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 111
            };
        }
    }
}
