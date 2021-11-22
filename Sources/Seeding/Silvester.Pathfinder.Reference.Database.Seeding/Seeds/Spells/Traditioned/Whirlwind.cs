using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Whirlwind : Template
    {
        public static readonly Guid ID = Guid.Parse("28cce1bd-e558-4861-b0b9-46fe4292ca7a");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Whirlwind",
                Level = 8,
                Range = "500 feet.",
                Duration = "Sustained up to 1 minute.",
                Area = "15-foot radius, 80-foot tall cylinder",
                IsDismissable = true,
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("96ed06fc-83af-4b59-a176-a662f9dfd534"), Type = TextBlockType.Text, Text = "Powerful winds coalesce into a devastating tornado. You can Cast this Spell only if you are outside or the ceiling is 80 feet or higher. All squares in the whirlwind are difficult terrain." };
            yield return new TextBlock { Id = Guid.Parse("0ec24a6c-6698-47df-9ade-cffbc1a727bc"), Type = TextBlockType.Text, Text = "All creatures in the area take 5d10 bludgeoning damage as powerful winds and debris buffet them, with a Reflex save. Each time you Sustain the Spell, you can move the whirlwind up to 30 feet in a straight line. Each creature the whirlwind moves through takes the damage, also with a Reflex save. A creature can be affected by a whirlwind only once per round." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("91846784-25e3-475e-be6e-210c2b9708d8"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("a1475846-a830-424d-9599-6f7a63861e25"), Type = TextBlockType.Text, Text = "Increase the bludgeoning damage by 1d10." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("09d5836e-1c41-45db-8f34-f65287a999a7"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes half damage.",
                Failure = "The creature takes full damage and rises 10 feet into the air. If it doesn�t have a fly Speed, the creature gains one equal to its Speed until it either reaches the ground or ceases to be in the whirlwind�s area, potentially falling when the spell ends or when it leaves the area.",
                CriticalFailure = "As failure, except the creature takes double damage and rises 20 feet into the air."
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Air.ID;
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1939a776-b15f-471c-9fa2-3f2a89bcae11"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 141
            };
        }
    }
}
