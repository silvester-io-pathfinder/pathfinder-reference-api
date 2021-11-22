using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ElementalConfluence : Template
    {
        public static readonly Guid ID = Guid.Parse("e4f425b6-ee9e-4f0e-b85b-cea72909dd5c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Elemental Confluence",
                Level = 6,
                Range = "60 feet.",
                Duration = "Sustained up to 1 minute.",
                Area = "10-foot burst.",
                IsDismissable = true,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a3d90b75-ea05-46bf-8542-703e4f0b71d8"), Type = TextBlockType.Text, Text = "You conjure four types of elementals who combine forces to form into a chaotic storm. The confluence has AC 28 and 120 Hit Points, weakness 10 to area effects, and immunity to bleed and poison. Creatures can move through the confluence; creatures within the confluence are concealed, and all creatures outside the confluence are concealed to creatures within it. When you Cast or Sustain this Spell, you choose up to two different types of elementals to act." };
            yield return new TextBlock { Id = Guid.Parse("69b883dc-76cb-44a0-a7f7-979217c1aa33"), Type = TextBlockType.Enumeration, Text = "Air (air, electricity) - The elemental looses a bolt of electricity from the confluence, dealing 4d4 electricity damage to creatures within 20 feet of the confluence, with a basic Reflex save. This doesn�t affect creatures that are completely inside of the confluence." };
            yield return new TextBlock { Id = Guid.Parse("f98ed869-e043-4f35-9f5e-dfbac135c039"), Type = TextBlockType.Enumeration, Text = "Earth (earth) - The confluence gains a +2 circumstance bonus to AC and resistance 10 to all physical damage (except adamantine) for 1 round." };
            yield return new TextBlock { Id = Guid.Parse("087c733a-5d4f-426e-8c27-de8db094c8bb"), Type = TextBlockType.Enumeration, Text = "Fire (fire) - Flames roar through the confluence, dealing 1d6 persistent fire damage to those partially or entirely inside the confluence." };
            yield return new TextBlock { Id = Guid.Parse("3995e231-b158-42e1-a676-2220797e0ff6"), Type = TextBlockType.Enumeration, Text = "Water (attack, water) - The elemental expels a powerful jet of water. Attempt a ranged spell attack against a target within 60 feet of the confluence, using your spell attack roll modifier. This attack ignores concealment granted by the confluence, and the elemental gets a +2 circumstance bonus on the spell attack roll against a target inside the confluence. The water deals 4d6 bludgeoning damage on a hit (doubled on a critical hit). This attack doesn�t count toward your multiple attack penalty." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Air.ID;
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Earth.ID;
            yield return Traits.Instances.Fire.ID;
            yield return Traits.Instances.Water.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9116a88f-8b4c-41e1-9911-a85d1fa6015c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 102
            };
        }
    }
}
