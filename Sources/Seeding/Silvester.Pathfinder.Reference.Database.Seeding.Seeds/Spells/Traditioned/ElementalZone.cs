using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ElementalZone : Template
    {
        public static readonly Guid ID = Guid.Parse("ba9d7ba1-cfc7-42b7-90b2-22f6d95b80ab");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Elemental Zone",
                Level = 2,
                Range = "120 feet.",
                Duration = "1 minute.",
                Area = "20-foot radius burst.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b4558100-798e-440c-8d7c-70a691036a49"), Type = TextBlockType.Text, Text = "Select an elemental trait: air, earth, fire, or water. Elemental zone gains the trait you chose. You imbue the area with the raw energy of that element, creating a zone that emits and amplifies magic of that type. The temperature might suddenly rise or fall, a storm cloud might form, and so on. Spells with the chosen elemental trait cast against creatures in the zone get a +2 status bonus to one damage type the spell deals based on the chosen trait: bludgeoning or electricity for air, bludgeoning for earth, fire for fire, and bludgeoning or cold for water. The caster chooses one type to add the bonus to if the spell deals more than one eligible type. This bonus is halved if the spell didn't use a spell slot (such as a cantrip, focus spell, or innate spell)." };
            yield return new TextBlock { Id = Guid.Parse("7c5628f9-2c8b-4bd9-b9c5-7082ff4f5375"), Type = TextBlockType.Text, Text = "The zone has no effect on the spell if the spell doesn't deal any damage of an eligible type." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("19638cde-4b44-4ecb-8373-f9729d9d9564"),
                Level = "+2",
                Details = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("639b87d3-4808-4129-ac9c-bb18c98249ec"), Type = TextBlockType.Text, Text = "The status bonus increases by 1." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("9562e1bb-b3bb-4440-b178-14bc9c10b801"), Traits.Instances.Evocation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d250c96f-c3e0-4a2e-a4c3-76ce7b89ecfa"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 104
            };
        }
    }
}
