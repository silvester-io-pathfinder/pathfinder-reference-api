using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class VampiricMaiden : Template
    {
        public static readonly Guid ID = Guid.Parse("2dcb92ab-b738-415b-9213-6ccb9b8d9e89");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Vampiric Maiden",
                Level = 4,
                Range = "30 feet.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f3d99d81-8a75-4f0e-92f3-254b0fdecda3"), Type = TextBlockType.Text, Text = "A ghostly iron maiden snaps shut on the target and drains its vitality for your gain. This deals 4d4 piercing damage and 4d4 negative damage, and the target must attempt a Fortitude save. You gain temporary HP equal to the negative damage the target takes (after applying resistances, weaknesses, and the like). You lose any remaining temporary HP after 1 minute." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("7654d263-ebc1-451f-8fbb-809fc8ee74ab"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("e21327c1-c312-4564-9521-7b4d4bb3934f"), Type = TextBlockType.Text, Text = "The piercing and negative damage increase by 1d4 each." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("c996defa-3d10-477e-adc5-29e777f0e77f"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes half damage.",
                Failure = "The target is briefly trapped within the vampiric maiden. The target takes full damage and is immobilized by the iron maiden for 1 round or until it uses an Interact action to extricate itself, whichever comes first.",
                CriticalFailure = "The target takes double damage and is immobilized by the vampiric maiden for 1 round or until it Escapes (the DC is your spell DC), whichever comes first."
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
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Negative.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("99c9f1be-0453-4dd1-8f6b-82cabd75740a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 227
            };
        }
    }
}
