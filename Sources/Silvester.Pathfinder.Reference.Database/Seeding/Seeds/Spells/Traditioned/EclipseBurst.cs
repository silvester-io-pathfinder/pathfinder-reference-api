using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class EclipseBurst : Template
    {
        public static readonly Guid ID = Guid.Parse("72bb1ec1-42b6-4da3-9109-00a1475da7cb");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Eclipse Burst",
                Level = 7,
                Range = "500 feet.",
                Area = "60-foot burst",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("796bb7c5-c37a-49b4-b5f3-56f422d80695"), Type = TextBlockType.Text, Text = "A globe of freezing darkness explodes in the area, dealing 8d10 cold damage to creatures in the area, plus 8d4 additional negative damage to living creatures. Each creature in the area must attempt a Reflex save." };
            yield return new TextBlock { Id = Guid.Parse("f578d8fe-e494-414c-9a6c-b8d071de0721"), Type = TextBlockType.Text, Text = "If the globe overlaps with an area of magical light or affects a creature affected by magical light, eclipse burst attempts to counteract the light effect." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("ceaff854-c9db-4fde-982f-2cdb485d2fa4"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("c376e8d5-9b3a-443d-84e2-da8b6e579299"), Type = TextBlockType.Text, Text = "The cold damage increases by 1d10 and the negative damage against the living increases by 1d4." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("c93b5272-9676-492d-9049-39dca3948fb5"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes half damage.",
                Failure = "The creature takes full damage.",
                CriticalFailure = "The creature takes double damage and becomes blinded by the darkness for an unlimited duration."
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Cold.ID;
            yield return Traits.Instances.Darkness.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Negative.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fccaef1e-d945-439d-a260-9bb9f6d8ee89"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 334
            };
        }
    }
}
