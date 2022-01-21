using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class MageHand : Template
    {
        public static readonly Guid ID = Guid.Parse("e7fd46a8-8455-4324-8bde-4fef118e207d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Mage Hand",
                Level = 1,
                Range = "30 feet.",
                IsDismissable = true,
                Duration = "Sustained.",
                Targets = "1 unattended object of light Bulk or less.",
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0cb91f4b-39b3-4eff-bbca-bf304ea89a20"), Type = TextBlockType.Text, Text = "You create a single magical hand, either invisible or ghostlike, that grasps the target object and moves it slowly up to 20 feet. Because you're levitating the object, you can move it in any direction. When you Sustain the Spell, you can move the object an additional 20 feet. If the object is in the air when the spell ends, the object falls." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("af79a569-6faf-4f9f-9da1-777f925f2606"),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("687ab638-b9f5-425e-b7ae-aa35f84df3d4"), Type = TextBlockType.Text, Text = "You can target an unattended object with a Bulk of 1 or less." }
                }
            };
            yield return new SpellHeightening
            {
                Id = Guid.Parse("de3d9f91-479b-43aa-9c54-cbfa769f2637"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("433e8dc6-5751-4c29-9dd7-bf665d933d5f"), Type = TextBlockType.Text, Text = "The range increases to 60 feet, and you can target an unattended object with a Bulk of 1 or less." }
                }
            };
            yield return new SpellHeightening
            {
                Id = Guid.Parse("0e2adec7-e195-43ac-85e2-0bba5f1c2285"),
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("e1698bb2-a36f-4dc1-b1c8-0a452eff6891"), Type = TextBlockType.Text, Text = "The range increases to 60 feet, and you can target an unattended object with a Bulk of 2 or less." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("424d1377-9ee5-466d-a678-9341b2da6bbf"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("cb754111-5798-4ea2-a48f-2ead4dc8ac8f"), Traits.Instances.Evocation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c7bd9073-2d80-4717-8823-1c7afad37cdf"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 349
            };
        }
    }
}
