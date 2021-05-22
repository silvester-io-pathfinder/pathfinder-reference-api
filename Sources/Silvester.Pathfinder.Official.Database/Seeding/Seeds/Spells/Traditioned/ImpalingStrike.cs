using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ImpalingStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("021b449e-942e-4664-84d3-ecd2827d701c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Impaling Strike",
                Level = 5,
                Range = "30 feet.",
                Duration = "1 minute.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a4dd2296-50c4-4e04-8015-714f04935ee7"), Type = TextBlockType.Text, Text = "You conjure a spike that thrusts up from the earth beneath a target creature, potentially impaling it. The spike is made of cold iron and deals 8d6 piercing damage. The target must attempt a Reflex save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("c81d3bb4-249b-4d9e-b339-ed5a1393da92"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("bbb8fc49-e0e9-4ba4-ba4b-fd45eea9fb88"), Type = TextBlockType.Text, Text = "The damage increases by 2d6." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("a31094d0-f8ed-4c86-b16d-ff4875cd7cff"),
                CriticalSuccess = "The target dodges the spike and is unaffected.",
                Success = "The target is struck by the spike and takes half damage.",
                Failure = "The target is impaled through a leg or another non-vital body part. The creature takes full damage and, if it’s standing on solid ground, becomes immobilized. It can attempt to Escape (the DC is your spell DC). While it remains impaled, it takes damage from any weakness to cold iron it has at the end of each of its turns.",
                CriticalFailure = "As failure, but the creature is impaled through a vital organ or its center of mass, taking double damage, and it is flat-footed as long as it’s impaled."
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
            yield return Traits.Instances.Conjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("925d9966-843b-4465-96e4-188a14a58e0c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 221
            };
        }
    }
}
