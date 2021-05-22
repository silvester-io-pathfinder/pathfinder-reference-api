using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class PowerWordBlind : Template
    {
        public static readonly Guid ID = Guid.Parse("422d220b-faf1-4380-865a-94f4becabb91");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Power Word Blind",
                Level = 7,
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
            yield return new TextBlock { Id = Guid.Parse("27fc90ca-993f-4b02-a531-212cba2e486f"), Type = TextBlockType.Text, Text = "You utter an arcane word of power that can make the target blinded upon hearing it. Once targeted, the target is then temporarily immune for 10 minutes. The effect of the spell depends on the target’s level." };
            yield return new TextBlock { Id = Guid.Parse("02bce5e7-5369-4955-8f47-9bfa75055b96"), Type = TextBlockType.Enumeration, Text = "11th or lower - The target is blinded permanently." };
            yield return new TextBlock { Id = Guid.Parse("452c3bc6-0c9d-4856-8153-7a44e99fbbb7"), Type = TextBlockType.Enumeration, Text = "12th to 13th -  The target is blinded for 1d4 minutes." };
            yield return new TextBlock { Id = Guid.Parse("98a6d70d-119d-45fb-ae75-4bad5d20dda9"), Type = TextBlockType.Enumeration, Text = "14th or higher -  The target is dazzled for 1 minute." };
            
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("158a388f-bd48-4799-b469-c419cc6f3fbf"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("cdde260d-7670-488a-8981-2a13fc788d61"), Type = TextBlockType.Text, Text = "The levels at which each outcome applies increase by 2." }
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Auditory.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e10fec1f-73b9-43d2-b026-be0b5d8bf0d9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 358
            };
        }
    }
}
