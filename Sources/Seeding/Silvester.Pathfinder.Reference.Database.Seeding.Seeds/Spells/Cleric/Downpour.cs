using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("1ce0a4fc-584e-4dc4-a0c5-ed7c69fe6d16"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("1aa80d94-1cb9-4e2a-b2b0-c087e5e48a1e"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("331fed0a-b0f7-4c77-8365-13d882450555"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("15aeb692-8c43-49b3-b8d8-4b8757b6979e"), Traits.Instances.Water.ID);
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
