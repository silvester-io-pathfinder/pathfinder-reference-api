using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Pyrotechnics : Template
    {
        public static readonly Guid ID = Guid.Parse("2d9fa0b3-c9ba-4e4f-8c95-79a6366fdb61");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Pyrotechnics",
                Level = 3,
                Range = "120 feet.",
                Targets = "1 fire.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("49294284-5355-43ed-a062-92d144b75623"), Type = TextBlockType.Text, Text = "You turn a fire into either a burst of blinding fireworks or a thick cloud of choking smoke, chosen when you Cast the Spell. The spell targets one fire source, which is immediately extinguished if it is a non-magical fire the size of a campfire or smaller. If the fire source is a creature, the creature takes 1d6 points of cold damage and is not extinguished." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("3ffbe429-d204-46b8-bc69-565db6989569"),
                Name = "Fireworks",
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature is dazzled until the end of its next turn.",
                Failure = "The creature is blinded until the end of its next turn.",
                CriticalFailure = "The creature is blinded for 1 minute."
            };

            yield return new RollableEffect
            {
                Id = Guid.Parse("8a41f419-f41a-4550-92e7-717874aad150"),
                Name = "Smoke Cloud",
                Success = " The creature is unaffected.",
                Failure = "The creature is sickened 1.",
                CriticalFailure = "The creature is sickened 1 and cannot recover from the sickened condition while in the area of the smoke cloud."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Fire.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b9716ba2-4260-4449-b05c-85aeab7e8cf0"),
                SourceId = Sources.Instances.Pathfinder152.ID,
                Page = 77
            };
        }
    }
}
