using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Sigil : Template
    {
        public static readonly Guid ID = Guid.Parse("912e35d7-ae91-44c2-8a21-239580a614d0");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Sigil",
                Level = 1,
                Range = "Touch.",
                IsDismissable = true,
                Duration = "Varies.",
                Targets = "1 creature or object.",
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("48cdd021-2c7c-4dfc-87ba-0f50ce63e956"), Type = TextBlockType.Text, Text = "You harmlessly place your unique magical sigil, which is about 1 square inch in size, on the targeted creature or object. The mark can be visible or invisible, and you can change it from one state to another by using an Interact action to touch the target. The mark can be scrubbed or scraped off with 5 minutes of work. If it’s on a creature, it fades naturally over the course of a week. The time before the mark fades increases depending on your heightened level." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("1a012ae5-60b9-4f83-be42-fe55cebdaf5f"),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("1d97f346-a1e6-46dd-a193-b6e3456be7de"), Type = TextBlockType.Text, Text = "The sigil instead fades after 1 month." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("855e14ec-fc3c-4094-900f-debd64d8b1af"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("4af15801-5961-4847-8f08-ff437efc9d53"), Type = TextBlockType.Text, Text = "The sigil instead fades after 1 year." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("8dc365b3-d095-4d35-b2c5-731323d08d26"),
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("ad1bea04-bb0b-4e65-b1d7-44baec09efd1"), Type = TextBlockType.Text, Text = "The sigil never fades." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2bcc7fa5-629b-4120-83e6-e44817909d0b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 369
            };
        }
    }
}
