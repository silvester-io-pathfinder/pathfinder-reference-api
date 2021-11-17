using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class UnusualAnatomy : Template
    {
        public static readonly Guid ID = Guid.Parse("d1c5821c-ebac-49cf-8403-7835a6e99e47");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Unusual Anatomy",
                Level = 5,
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1ee77545-d18d-4e4c-b6c9-275bdccd5bcc"), Type = TextBlockType.Text, Text = "You transform your flesh and organs into a bizarre amalgam of glistening skin, rough scales, tufts of hair, and tumorous protuberances. This has three effects:" };
            yield return new TextBlock { Id = Guid.Parse("64091158-1c38-4811-a13a-d62d83663063"), Type = TextBlockType.Enumeration, Text = "You gain resistance 10 to precision damage and resistance 10 to extra damage from critical hits. If the resistance is greater than the extra damage, it reduces the extra damage to 0 but doesn’t reduce the attack’s normal damage." };
            yield return new TextBlock { Id = Guid.Parse("2e31a000-50ab-4baa-83f0-38c100b3446c"), Type = TextBlockType.Enumeration, Text = "You gain darkvision." };
            yield return new TextBlock { Id = Guid.Parse("4e7363d0-6262-46c6-8507-f845dc270538"), Type = TextBlockType.Enumeration, Text = "Acid oozes from your skin. Any creature that hits you with an unarmed attack or with a non-reach melee weapon takes 2d6 acid damage." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("6adf0e65-f0fa-4254-966d-0fbbdd779d8b"),
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("1bcef566-2fe3-48e5-8a80-d9c556b86410"), Type = TextBlockType.Text, Text = "The resistances increase by 5, and the acid damage increases by 1d6." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Polymorph.ID;
            yield return Traits.Instances.Sorcerer.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9adcde94-9702-482b-b1bc-eea8f9075fda"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 405
            };
        }
    }
}
