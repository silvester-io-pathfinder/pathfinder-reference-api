using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ShiftingForm : Template
    {
        public static readonly Guid ID = Guid.Parse("8c889ff7-c2b6-4c13-84f3-ebe934d07176");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shifting Form",
                Level = 4,
                IsDismissable = true,
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Wizard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("84122d03-7e6a-4bc1-bef7-7754aed15c0f"), Type = TextBlockType.Text, Text = "You gain one of the following abilities of your choice. You can Dismiss this spell." };
            yield return new TextBlock { Id = Guid.Parse("868cef53-da5a-4c06-afc0-8200ec8172c6"), Type = TextBlockType.Enumeration, Text = "You gain a 20-foot status bonus to your Speed." };
            yield return new TextBlock { Id = Guid.Parse("a2c46a4a-94a7-43d1-ae98-28d123616365"), Type = TextBlockType.Enumeration, Text = "You gain a climb or swim Speed equal to half your Speed." };
            yield return new TextBlock { Id = Guid.Parse("915c86c6-17c5-4b9c-a3bc-60684727951f"), Type = TextBlockType.Enumeration, Text = "You gain darkvision." };
            yield return new TextBlock { Id = Guid.Parse("a1257232-a85f-4392-b71b-3ff60b77c492"), Type = TextBlockType.Enumeration, Text = "You gain a pair of claws. These are agile finesse unarmed attacks that deal 1d8 slashing damage." };
            yield return new TextBlock { Id = Guid.Parse("f014b191-fe50-411d-ba4d-5bcad4416be9"), Type = TextBlockType.Enumeration, Text = "You gain scent 60 feet (imprecise)." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Morph.ID;
            yield return Traits.Instances.Transmutation.ID;
            yield return Traits.Instances.Wizard.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2e12c633-7d53-4211-8fca-733cd3e153ff"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 407
            };
        }
    }
}
