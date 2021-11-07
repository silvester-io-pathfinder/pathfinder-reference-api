using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{

    public class ShiftingSand : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shifting Sand",
                Level = 3,
                Range = "30 feet.",
                Area = "A horizontal earthen or sandy surface within a 20-foot burst.",
                Duration = "Sustained up to 1 minute.",
                IsDismissable = true,
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You cause the surface to heave. The area becomes difficult terrain and any tracks in the area are destroyed by the churning ground. Creatures standing in the area take a –1 status penalty to Acrobatics checks to Balance and Tumble Through and Athletics checks to High Jump and Long Jump. The first time each round you Sustain the Spell, you can move the churning area up to 10 feet in any direction. Creatures immobilized by the spell are carried along with the shifting sand in the same direction, if possible; this movement is forced movement. Creatures that enter or begin their turn standing in the shifting sand must attempt a Reflex save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "5th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The status penalty increases to –2 and the spell’s range increases to 60 feet." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "7th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The status penalty increases to –3, the spell’s range increases to 60 feet, and the spell’s area increases to a 30-foot burst." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "9th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The status penalty increases to –4, the spell’s range increases to 60 feet, and the spell’s area increases to a 40-foot burst." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse(""),
                CriticalSuccess = "The creature is unaffected and ignores the area’s difficult terrain and penalty to skill checks until the end of its turn.",
                Success = "The creature ignores the area’s penalty to skill checks until the end of its turn.",
                Failure = "The creature is affected normally by the spell this turn.",
                CriticalFailure = "The creature becomes immobilized within the spell’s area until it Escapes. If the creature was already immobilized by shifting sands, it also falls prone."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
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
            yield return Traits.Instances.Earth.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 110
            };
        }
    }
}
