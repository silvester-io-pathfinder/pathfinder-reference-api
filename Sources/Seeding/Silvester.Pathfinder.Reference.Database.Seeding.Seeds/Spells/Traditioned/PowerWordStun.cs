using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PowerWordStun : Template
    {
        public static readonly Guid ID = Guid.Parse("af9e64ed-a4a9-42bd-8b4a-e8adccffb4fc");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Power Word Stun",
                Level = 8,
                Range = "30 feet.",
                Duration = "Varies.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cd8f0729-d6b6-41cc-a6e0-b3c0fe90fc2f"), Type = TextBlockType.Text, Text = "You stun the target with an arcane word of power. Once targeted, the target is then temporarily immune for 10 minutes. The effect of the spell depends on the target's level." };
            yield return new TextBlock { Id = Guid.Parse("8d0011e6-c38e-4863-95e8-101d185517b9"), Type = TextBlockType.Enumeration, Text = "13th or Lower - The target is stunned for 1d6 rounds." };
            yield return new TextBlock { Id = Guid.Parse("e4c39da0-52d6-4f8b-b1ca-b45a411161fa"), Type = TextBlockType.Enumeration, Text = "14th to 15th - The target is stunned for 1 round." };
            yield return new TextBlock { Id = Guid.Parse("4c893f47-5fdf-410d-8b5d-1b681d8893a3"), Type = TextBlockType.Enumeration, Text = "16th or Higher - The target is stunned 1." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("75efd8d4-4900-4a59-b95c-c5848ead2733"), 
                Level = "+!",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("7c76601c-d40a-4ce0-a62d-89423bd48153"), Type = TextBlockType.Text, Text = "The levels at which each outcome applies increase by 2." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("4a9b1d90-a5f1-46ac-9d03-e3bfcf57831b"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("15a3ff99-9570-431f-8b1a-f16b77470944"), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse("aa7c82ed-e245-4a4b-be46-597431f433da"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("6baf8393-3d79-4ffd-8a94-61af4743e134"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("725b42b4-7b5b-4e55-be0b-d0aee8b0d49c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 359
            };
        }
    }
}
