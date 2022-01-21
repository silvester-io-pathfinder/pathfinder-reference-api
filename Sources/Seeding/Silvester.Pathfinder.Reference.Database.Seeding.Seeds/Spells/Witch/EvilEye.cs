using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class EvilEye : Template
    {
        public static readonly Guid ID = Guid.Parse("5357885a-fcae-43c9-bfa0-61e6e41a2e6e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Evil Eye",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Witch.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f2c7628d-2b2d-4250-aee8-25d6ead5a5f6"), Type = TextBlockType.Text, Text = "Your fix your eye on the target, imposing a malevolent hex. The target becomes frightened based on the results of its Will save. This condition value can't be reduced below 1 while the spell is active and you can see the target. Regardless of the outcome, the target is then temporarily immune for 1 minute." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("98d96fc4-6fcf-47fb-bfa0-6ac47b882188"),
                Success = "The target is unaffected.",
                Failure = "The target is frightened 1.",
                CriticalFailure = "Critical Failure The target is frightened 2."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("4d611d34-45f7-4c9f-add0-ffa043596dbd"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("ffd36a92-da5c-4697-8e03-3ab469753a53"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("2bc59619-3a1f-4996-8931-97aafe363d3b"), Traits.Instances.Curse.ID);
            builder.Add(Guid.Parse("398b2cb3-d811-4bca-ab8e-066373684010"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("97764e7c-c632-4f72-8481-1515b196c6f0"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("3491bc55-a4d4-4742-bb20-1dfb8e98d6b0"), Traits.Instances.Fear.ID);
            builder.Add(Guid.Parse("7c7e5266-bc86-4ce8-a94f-3d98abdc9886"), Traits.Instances.Hex.ID);
            builder.Add(Guid.Parse("2e105ed8-9324-40b2-a1c5-67387c3305b6"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("01eba6dd-f497-436f-90f7-fb57a3208e88"), Traits.Instances.Witch.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("98b6b3ff-8aca-4bd8-8d25-552a446972a5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 238
            };
        }
    }
}
