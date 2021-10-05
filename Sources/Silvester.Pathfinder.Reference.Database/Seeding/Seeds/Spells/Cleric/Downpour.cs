using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Downpour : Template
    {
        public static readonly Guid ID = Guid.Parse("8c2d28f7-2b1d-4dbd-8f5b-481038cb7f5c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Downpour",
                Level = 4,
                Range = "120 feet.",
                Area = "30-foot burst.",
                Duration = "1 minute.",
                DomainId = Domains.Instances.Water.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5ae5bd16-ee7d-46ba-853c-5f8b9a535629"), Type = TextBlockType.Text, Text = "You call forth a torrential downpour, which extinguishes nonmagical flames. Creatures in the area are concealed and gain fire resistance 10. Creatures outside the area are concealed to those inside the area. Creatures with weakness to water that end their turns in the area take damage equal to their weakness." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("96de559c-6581-402e-a094-0ce6373b3cca"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("d22cb870-532a-42e7-9b9e-87d98f68823c"), Type = TextBlockType.Text, Text = "The fire resistance increases by 2." }
                }
            };
        }
        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Water.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("347edafe-4dad-4aba-89a5-468acefbc199"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 391
            };
        }
    }
}
