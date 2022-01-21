using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class CounterPerformance : Template
    {
        public static readonly Guid ID = Guid.Parse("b6aa72a7-3729-4c21-9047-b4e50f8b16a7");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Counter Performance",
                Level = 1,
                Area = "60-foot emanation.",
                Trigger = "You or an ally within 60 feet rolls a saving throw against an auditory or visual effect.",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                ClassId = Classes.Instances.Bard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1705a317-25fc-4364-abb6-50fd83cb393c"), Type = TextBlockType.Text, Text = "Your performance protects you and your allies. Roll a Performance check for a type you know: an auditory performance if the trigger was auditory, or a visual one for a visual trigger. You and allies in the area can use the better result between your Performance check and the saving throw." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("f346aa7c-c46b-4fa5-ad6d-a19e69c4de8e"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("0d3ae0ed-363c-4cb3-8bc8-171be5aacaa6"), Traits.Instances.Bard.ID);
            builder.Add(Guid.Parse("b07e7eab-77aa-473e-baae-49c8350114f5"), Traits.Instances.Composition.ID);
            builder.Add(Guid.Parse("fa64dba7-ec66-4f0c-843b-196585aee266"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("f5a7ebf1-0a85-4cac-8b5c-764f55464f54"), Traits.Instances.Fortune.ID);
            builder.Add(Guid.Parse("05371dd6-ad13-4e19-b255-017f6bca8840"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c8215602-216d-46f6-89ac-c2e7a3e81cb3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 386
            };
        }
    }
}
