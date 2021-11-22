using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class BoilBlood : Template
    {
        public static readonly Guid ID = Guid.Parse("c600e4fb-ebbe-45d0-9435-b07a0dc44a46");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Boil Blood",
                Level = 8,
                Range = "60 feet.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("eef1845e-5672-41ee-87c9-ffa968eaf110"), Type = TextBlockType.Text, Text = "You heat a foe�s blood and boil it within its veins. The target takes 10d10 fire damage, with a Fortitude save. A nonliving creature with blood in its body (such as a vampire) can be affected, but a creature with no blood is immune." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("77a20c82-f4e0-474e-9832-26898a683ebe"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("d5a773d7-0c6a-4800-8cf4-9624a0db1d27"), Type = TextBlockType.Text, Text = "The damage increases by 1d10." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("a06f0023-4099-4f81-95f1-9590e3440bae"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes half damage.",
                Failure = "The target takes full damage and is drained 2.",
                CriticalFailure = "The target takes double damage and is drained 3."
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
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Fire.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("30422963-3790-4e9a-ad71-ece32e194385"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 92
            };
        }
    }
}
