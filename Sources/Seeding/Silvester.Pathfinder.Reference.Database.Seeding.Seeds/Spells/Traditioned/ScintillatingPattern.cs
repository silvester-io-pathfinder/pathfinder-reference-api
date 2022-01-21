using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ScintillatingPattern : Template
    {
        public static readonly Guid ID = Guid.Parse("b4565c07-e74e-4651-be58-dee1715a470b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Scintillating Pattern",
                Level = 8,
                Range = "120 feet.",
                Area = "20-foot burst.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c06b220f-8d39-4d78-8121-a29d0880816c"), Type = TextBlockType.Text, Text = "A field of cascading, ever-changing colors manifests in the air. Creatures are dazzled while inside the pattern, as are those within 20 feet of the pattern's area. A creature must attempt a Will save if it is inside the pattern when you cast it, enters the pattern, ends its turn within the pattern, or uses a Seek or Interact action on the pattern. A creature currently affected by the pattern doesn't need to attempt new saves." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("8d2841ea-2885-46d2-a331-9b0a8463f3da"),
                Success = "The creature is unaffected.",
                Failure = "The creature is confused for 1d4 rounds.",
                CriticalFailure = "The creature is stunned for 1d4 rounds. After the stunned condition ends, the creature is confused for the remaining duration of the spell."
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("c474597a-c6a8-46df-8c8b-eef2bf4a315d"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("a0137ebe-8fa1-418f-9a1c-334c16981f44"), Traits.Instances.Incapacitation.ID);
            builder.Add(Guid.Parse("a8969e2a-026a-4feb-8231-281679d008db"), Traits.Instances.Visual.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("34e24d64-ef2b-400b-a242-9c99fd2904b8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 367
            };
        }
    }
}
