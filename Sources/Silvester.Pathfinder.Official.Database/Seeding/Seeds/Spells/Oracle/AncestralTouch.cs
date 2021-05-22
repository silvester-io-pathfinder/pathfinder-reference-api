using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class AncestralTouch : Template
    {
        public static readonly Guid ID = Guid.Parse("161689fc-881b-4888-b108-46f0bab8373c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Ancestral Touch",
                Level = 1,
                Range = "Touch.",
                Targets = "1 living creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Oracle.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
                MysteryId = Mysteries.Instances.Ancestors.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0d5303bc-ad15-435b-b98c-5bce486020d6"), Type = TextBlockType.Text, Text = "You touch a creature and force them to see and feel the ancestors surrounding you. The target takes 1d4 mental damage, with results depending on a Will save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("408fcdf8-87bd-434d-8c72-970c9d264546"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("6c623cf0-2b1c-4676-b6a6-7a38e8554b1b"), Type = TextBlockType.Text, Text = "The mental damage increases by 1d4." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("27601d94-91eb-4324-bfec-4edd01ab326f"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes half damage.",
                Failure = "The target is frightened 1 and takes full damage.",
                CriticalFailure = "The target is frightened 2 and takes double damage."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cursebound.ID;
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Fear.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Oracle.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("62915d5d-0c43-44fd-bb65-a5c93c51588f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 230
            };
        }
    }
}
