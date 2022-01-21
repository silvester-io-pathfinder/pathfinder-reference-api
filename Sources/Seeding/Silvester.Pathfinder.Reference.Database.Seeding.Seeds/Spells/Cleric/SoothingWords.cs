using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SoothingWords : Template
    {
        public static readonly Guid ID = Guid.Parse("c431e47e-b879-4772-b9a9-082f686f8292");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Soothing Words",
                Level = 1,
                Range = "30 feet.",
                Duration = "1 round.",
                Targets = "1 ally.",
                DomainId = Domains.Instances.Family.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3fe2d807-2d11-46d8-9d76-646373023e83"), Type = TextBlockType.Text, Text = "You attempt to calm the target by uttering soothing words in a calm and even tone. The target gains a +1 status bonus to Will saving throws. This bonus increases to +2 against emotion effects." };
            yield return new TextBlock { Id = Guid.Parse("c9f2bc73-a77d-48a4-9175-632c1f4e32f1"), Type = TextBlockType.Text, Text = "In addition, when you Cast this Spell, you can attempt to counteract one emotion effect on the target." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("02919c19-b3ca-4ecc-843d-04f9e7e75f67"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("9f916fef-622f-4c56-bbca-db69fb93014c"), Type = TextBlockType.Text, Text = "The bonus to saves increases to +2, or +3 against emotion effects." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("c37c23ac-54c9-45b4-9f4a-12b5e371aaf7"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("44627780-4533-4d42-97bc-b56f5cf3914b"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("1ec80fec-371a-48f4-926f-72e86d12f39a"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("23891512-46be-4d27-84ed-e1cca45c05f0"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("dc883d18-94b1-41a6-a5e9-f5c45ca2233b"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5a7b52ba-3e4f-428e-bc13-985bbca60957"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 396
            };
        }
    }
}
