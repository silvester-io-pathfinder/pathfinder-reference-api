using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class PreciousMetals : Template
    {
        public static readonly Guid ID = Guid.Parse("c8a339ea-1f88-4d4c-aea8-945599b99cfd");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Precious Metals",
                Level = 4,
                Range = "Touch.",
                Duration = "1 minute.",
                Targets = "1 metal weapon, up to 10 pieces of metal or metal-tipped ammunition, 1 suit of metal armor, or up to 1 bulk of metal material (such as coins).",
                DomainId = Domains.Instances.Wealth.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fb8fcb88-0c4d-45f8-a5d3-2bc17bdc6f94"), Type = TextBlockType.Text, Text = "Your deity blesses base metals to transform them into precious materials. The target item transforms from its normal metal into cold iron, copper, gold, iron, silver, or steel (the details for these metals are found on pages 577–579). An item transmuted in this way deals damage according to its new material. For example, a steel sword transmuted to cold iron would deal additional damage to a creature with a weakness to cold iron." };
            yield return new TextBlock { Id = Guid.Parse("d7cbecd5-384e-42ad-a688-5730e4a45f9b"), Type = TextBlockType.Text, Text = "This change is clearly magical and temporary, so the item’s monetary value doesn’t change; you couldn’t transmute copper coins to gold and use those coins to purchase something or as a cost for a spell." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("a4b9078d-9762-4cc5-988f-8179db982c44"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("2d3ea1f0-d06c-452a-a7d5-ee54614f4b27"), Type = TextBlockType.Text, Text = "Add adamantine (page 578 of the Core Rulebook) and mithral (page 579) to the list of metals you can transform the item into." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5f2f9498-5cb8-4833-aaa3-cab1bb2af7d1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 395
            };
        }
    }
}
