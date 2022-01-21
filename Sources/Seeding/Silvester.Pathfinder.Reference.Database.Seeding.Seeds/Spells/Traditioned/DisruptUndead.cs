using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DisruptUndead : Template
    {
        public static readonly Guid ID = Guid.Parse("db143e7b-8212-4350-a09f-09205811470e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Disrupt Undead",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 undead creature.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ac325502-59d1-4250-91b4-917dab957ede"), Type = Utilities.Text.TextBlockType.Text, Text = "You lance the target with energy. You deal 1d6 positive damage plus your spellcasting ability modifier. The target must attempt a basic Fortitude save." };
        }


        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("7c7d9f59-2899-4af7-9596-cf6a7711da5a"),
                CriticalFailure = "The creature is also enfeebled 1 for 1 round."
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("637c1c9a-e2f9-497d-85fc-9ca72fbba552"), 
                Level = "+1", 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b80d3ed5-a258-46bf-aba7-9f4623cac77a"), Type = Utilities.Text.TextBlockType.Text, Text = "The damage increases by 1d6." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("3ea1ef96-31ee-49c0-b8a5-a161f230f713"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("d1de6193-bb17-4de1-baee-1d71ebd54afb"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("5d911d20-2579-4fa2-940b-f50d133bd4a8"), Traits.Instances.Positive.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f6420b7a-2e61-4dc3-a939-fc008e150ac4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 331
            };
        }
    }
}
