using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("ac600317-2de8-4cb6-bb47-839251febb89"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("006edef4-ddcc-400e-b004-71352c744528"), Traits.Instances.Cursebound.ID);
            builder.Add(Guid.Parse("b68b8522-d8c8-4c4c-b2fc-f8b1d51aa285"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("ff92eb62-9367-4ac4-8796-54135992125a"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("99ee4600-99ba-4166-8029-919a2ed3ed8c"), Traits.Instances.Fear.ID);
            builder.Add(Guid.Parse("b6b7dae7-9752-41af-a8f5-fda1fa585401"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("34f50fe6-a5d6-4a2c-9e5c-2939045b133b"), Traits.Instances.Oracle.ID);
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
