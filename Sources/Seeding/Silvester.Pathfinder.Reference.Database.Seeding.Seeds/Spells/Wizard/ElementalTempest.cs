using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ElementalTempest : Template
    {
        public static readonly Guid ID = Guid.Parse("8ae2add9-cf35-4cac-95f0-dea69b4eeaf4");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Elemental Tempest",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Wizard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("11f0fa7a-9e28-4ca5-8d0a-6ff1eb04a6d3"), Type = TextBlockType.Text, Text = "Your spellcasting surrounds you in a storm of elemental energy. If the next action you take is to Cast a Spell from your wizard spell slots that's an evocation spell dealing acid, cold, electricity, or fire damage, a 10-foot emanation of energy surrounds you as you cast the spell. Foes in the area take 1d6 damage per spell level of the spell you just cast of the same damage type the spell deals (choose one if it deals multiple types). Combine the damage from both elemental tempest and the other spell against foes who take damage from both before applying bonuses, penalties, resistance, weakness, and the like." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("b4324c83-1415-4140-b601-854e7d06c910"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("92b7fd90-d788-4254-8396-247c4bfbd2c5"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("2b11ca47-d62d-4880-b72d-bb203903cfd4"), Traits.Instances.Metamagic.ID);
            builder.Add(Guid.Parse("a9605bb6-3836-4b01-aff8-124bf11a5e32"), Traits.Instances.Wizard.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8b1761a3-6977-4f48-b687-62cb46c4b600"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 406
            };
        }
    }
}
