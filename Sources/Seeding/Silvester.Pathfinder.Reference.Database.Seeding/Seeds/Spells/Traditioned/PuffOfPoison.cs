using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PuffOfPoison : Template
    {
        public static readonly Guid ID = Guid.Parse("de3f0e8c-3c0a-49a4-974a-9cd820d496a8");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Puff of Poison",
                Level = 1,
                Range = "5 feet.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fcef7752-6273-4158-9f2f-30e69114311d"), Type = TextBlockType.Text, Text = "You exhale a shimmering cloud of toxic breath at an enemy�s face. The target takes poison damage equal to your spellcasting modifier and 2 persistent poison damage, depending on its Fortitude save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("1483376c-e465-4ed0-8b01-a9fed35c48c1"),
                Level = "+2",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("03579d8b-53fb-4da5-9375-9ada4fea3fe1"), Type = TextBlockType.Text, Text = "The initial poison damage increases by 1d8 and the persistent poison damage increases by 1." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("eaf4cf92-f61d-4ded-8029-a269454ce17f"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The target takes half initial and persistent damage.",
                Failure = "The target takes full initial and persistent damage.",
                CriticalFailure = "The target takes double initial and persistent damage."
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
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Inhaled.ID;
            yield return Traits.Instances.Poison.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("de8e93f3-d60e-49c0-8765-358d8877b8a0"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 124
            };
        }
    }
}
