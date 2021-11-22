using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PositiveAttunement : Template
    {
        public static readonly Guid ID = Guid.Parse("082ad1a4-606a-4b27-80a2-a2283b2739ec");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Positive Attunement",
                Level = 3,
                Range = "Touch.",
                Duration = "Sustained up to 1 minute.",
                Targets = "1 living or undead creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cc71abb5-1b1e-4176-9a4e-bb0f3eb92a7c"), Type = TextBlockType.Text, Text = "You attune a creature to the Positive Energy Plane, connecting its life force without fully transporting it. The creature�s appearance becomes more brightly colored. If the creature is living, it heals 1d8 Hit Points immediately and at the end of each of your turns. Effects that increase healing only increase the initial healing." };
            yield return new TextBlock { Id = Guid.Parse("40ab56c3-ceed-4135-a8e5-fe3946f1f5e1"), Type = TextBlockType.Text, Text = "If the creature is undead or has negative healing, it instead takes 1d8 positive damage, depending on the result of its Will save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("0d08bd24-6de4-41b5-a192-77a7be1dc483"),
                Level = "+3",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("ad24d5c0-b826-4ea0-9fae-c1509848d966"), Type = TextBlockType.Text, Text = "The damage and healing each increase by 1d8." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("bee4a344-f8eb-400d-ad41-8f19816cda21"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature is damaged once and the spell ends.",
                Failure = "The creature is damaged immediately and at the end of each of your turns (so twice in the round you Cast the Spell).",
                CriticalFailure = "As failure, and the damage is doubled."
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Healing.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Positive.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3cc5ebc1-b713-46b8-a816-1065c853382d"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 122
            };
        }
    }
}
