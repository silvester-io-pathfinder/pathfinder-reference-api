using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Prestidigitation : Template
    {
        public static readonly Guid ID = Guid.Parse("e08d32af-b2da-42a3-89f2-fc6df9cf0b91");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Prestidigitation",
                Level = 1,
                Range = "10 feet.",
                IsDismissable = true,
                Duration = "Sustained.",
                Targets = "1 object (cook, lift, or tidy only.)",
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a14fafcd-3535-49df-8045-5fcee62c98c5"), Type = TextBlockType.Text, Text = "The simplest magic does your bidding. You can perform simple magical effects for as long as you Sustain the Spell. Each time you Sustain the Spell, you can choose one of four options." };
            yield return new TextBlock { Id = Guid.Parse("57e95279-193c-4a08-b603-3ab49969adbf"), Type = TextBlockType.Enumeration, Text = "Cook - Cool, warm, or flavor 1 pound of nonliving material." };
            yield return new TextBlock { Id = Guid.Parse("47e06c3b-ccac-4eb7-9c66-1f63538cd5fd"), Type = TextBlockType.Enumeration, Text = "Lift - Slowly lift an unattended object of light Bulk or less 1 foot off the ground." };
            yield return new TextBlock { Id = Guid.Parse("4fd44b45-7f1a-41f2-ad71-32f73d80e1f5"), Type = TextBlockType.Enumeration, Text = "Make - Create a temporary object of negligible Bulk, made of congealed magical substance. The object looks crude and artificial and is extremely fragile—it can’t be used as a tool, weapon, or spell component." };
            yield return new TextBlock { Id = Guid.Parse("7bc6898c-63fa-48be-a57b-a29543696ec8"), Type = TextBlockType.Enumeration, Text = "Tidy - Color, clean, or soil an object of light Bulk or less. You can affect an object of 1 Bulk with 10 rounds of concentration, and a larger object a 1 minute per Bulk." };
            yield return new TextBlock { Id = Guid.Parse("4f5fcee9-1300-4dd5-a021-8804b1b50116"), Type = TextBlockType.Text, Text = "Prestidigitation can’t deal damage or cause adverse conditions. Any actual change to an object (beyond what is noted above) persists only as long as you Sustain the Spell." };
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
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("13bfd024-6791-4047-824e-86ac973e020b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 359
            };
        }
    }
}
