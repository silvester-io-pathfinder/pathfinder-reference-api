using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
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
            yield return new TextBlock { Id = Guid.Parse("11f0fa7a-9e28-4ca5-8d0a-6ff1eb04a6d3"), Type = TextBlockType.Text, Text = "Your spellcasting surrounds you in a storm of elemental energy. If the next action you take is to Cast a Spell from your wizard spell slots that’s an evocation spell dealing acid, cold, electricity, or fire damage, a 10-foot emanation of energy surrounds you as you cast the spell. Foes in the area take 1d6 damage per spell level of the spell you just cast of the same damage type the spell deals (choose one if it deals multiple types). Combine the damage from both elemental tempest and the other spell against foes who take damage from both before applying bonuses, penalties, resistance, weakness, and the like." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Metamagic.ID;
            yield return Traits.Instances.Wizard.ID;
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
