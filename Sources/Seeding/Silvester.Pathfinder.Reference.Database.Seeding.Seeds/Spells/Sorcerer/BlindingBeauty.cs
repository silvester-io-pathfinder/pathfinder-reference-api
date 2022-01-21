using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class BlindingBeauty : Template
    {
        public static readonly Guid ID = Guid.Parse("23bf8fed-66e0-4e3b-b0bc-629ddf8dddfc");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Blinding Beauty",
                Level = 3,
                Area = "30-foot cone.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3a2d3a72-630c-4423-9c65-3778ff433cff"), Type = TextBlockType.Text, Text = "You channel the allure of your nymph bloodline into a terribly beautiful glance. Each enemy in the area must attempt a Will saving throw." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("452a348a-c5c8-44eb-8ebd-9febeee168ac"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature is dazzled until the start of its next turn.",
                Failure = "The creature is blinded until the start of its next turn.",
                CriticalFailure = "The creature is blinded for 1 minute."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("046663c4-4116-4f69-8462-65f1d40fc2bf"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("be75c674-6b4f-4c6c-b723-fdb27b5b00ac"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("8a5bf827-21c6-4d2a-992a-b80879bc8e73"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("a1a50923-017f-4e57-922d-91ccdf548e83"), Traits.Instances.Incapacitation.ID);
            builder.Add(Guid.Parse("21d1a2b1-2455-495f-a5d8-a50d6c7a1dec"), Traits.Instances.Sorcerer.ID);
            builder.Add(Guid.Parse("5eea1062-cfe6-4ecd-bb32-b320489ba893"), Traits.Instances.Visual.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7a56976d-f03f-4d00-a9c8-e9b9d7a2e5ea"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 235
            };
        }
    }
}
