using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ElementEmbodied : Template
    {
        public static readonly Guid ID = Guid.Parse("4c40de87-71b1-4fd1-b707-f475cb1c838c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Element Embodied",
                Level = 10,
                Duration = "1 minute.",
                IsDismissable = true,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d45a6b5b-3837-4624-8370-5f76170d3d6c"), Type = TextBlockType.Text, Text = "Drawing upon the deepest wells of magic in an elemental plane, you transform into a spectacular elemental. You can choose between an air elemental, earth elemental, fire elemental, or water elemental. Your battle form is Gargantuan, and you must have enough space to expand into or the spell is lost. While in this form, you gain the elemental trait and the trait for the element you choose. You can Dismiss the spell." };
            yield return new TextBlock { Id = Guid.Parse("a0bbd4e6-708f-4e6c-96f4-defd60ec3972"), Type = TextBlockType.Text, Text = "You gain the following statistics and abilities regardless of which battle form you choose:" };
            yield return new TextBlock { Id = Guid.Parse("17011f96-0ec1-4092-be76-c3bf23511142"), Type = TextBlockType.Enumeration, Text = "AC = 25 + your level. Ignore your armor�s check penalty and Speed reduction." };
            yield return new TextBlock { Id = Guid.Parse("0c511eb7-c280-4ff4-bcfe-46a6f5343fd7"), Type = TextBlockType.Enumeration, Text = "30 temporary Hit Points." };
            yield return new TextBlock { Id = Guid.Parse("b3d92167-0b7a-4dd7-b7a0-fc5d7f42a278"), Type = TextBlockType.Enumeration, Text = "Darkvision." };
            yield return new TextBlock { Id = Guid.Parse("59e57f66-67e0-45d5-aa75-f561c2c52900"), Type = TextBlockType.Enumeration, Text = "One or more attacks specific to the battle form you choose, which are the only attacks you can use. You�re trained with them. Your attack modifier is +34, and you use the listed damage. These attacks are Dexterity based if you choose an air or fire elemental, or Strength based if you choose an earth or water elemental. (This distinction doesn�t change the statistics, but matters for the enfeebled and clumsy conditions, for example). If your unarmed attack modifier is higher, you can use it instead." };
            yield return new TextBlock { Id = Guid.Parse("1df0ece8-63a0-4081-98d3-79b6f162b2e1"), Type = TextBlockType.Enumeration, Text = "Acrobatics modifier of +36 for air or fire elemental or Athletics modifier of +36 for earth or water elemental, unless your own modifier is higher." };
            yield return new TextBlock { Id = Guid.Parse("0a826caf-2acb-489b-922f-2e2ba726f70b"), Type = TextBlockType.Text, Text = "You also gain specific abilities based on the type of elemental you choose:" };
            yield return new TextBlock { Id = Guid.Parse("9fe6cd96-a421-4d61-9437-04f87b140508"), Type = TextBlockType.Enumeration, Text = "Air Elemental fly Speed 80 feet; High Winds (air, aura) 30 feet. Air within the emanation is difficultterrain for flying creatures that don�t have the air trait; Swiftness Your movement doesn�t trigger reactions; Melee [one-action] gust (reach 25 feet), Damage 3d12+11 bludgeoning plus Push 10 feet; Ranged [one-action] lightning lash (range increment 80 feet), Damage 3d12+4 electricity." };
            yield return new TextBlock { Id = Guid.Parse("1a7161e4-56cf-4bf4-b5ac-6c042afe3f8d"), Type = TextBlockType.Enumeration, Text = "Earth Elemental 30 feet, burrow 20 feet; resistance 5 to physical; Spike Stones (aura, earth) 30 feet. The area is difficult terrain and hazardous terrain. A creature without the earth trait that moves on the ground in the area takes 5 piercing damage for every square of that area it moves into; Rocky Toughness You gain 40 temporary Hit Points when you choose this form instead of 30; Melee [one-action] fist (reach 25 feet), Damage 3d12+15 bludgeoning; Ranged [one-action] rock (range increment 40 feet), Damage 4d8+6 bludgeoning." };
            yield return new TextBlock { Id = Guid.Parse("903e6df5-dc72-4c72-9e32-aa6f1d915807"), Type = TextBlockType.Enumeration, Text = "Fire Elemental 50 feet; immunity to fire; weakness to cold 10; Intense Heat (aura, fire) 30 feet. A creature that enters the aura or starts its turn in the aura takes 5d6 fire damage with a basic Reflex save against your spell DC. A creature can take damage from the aura only once per round; Melee [one-action] tendril (reach 25 feet), Damage 3d10+12 fire plus 2d6 persistent fire; Ranged [one-action] fire mote (range increment 60 feet), Damage 4d8+6 bludgeoning." };
            yield return new TextBlock { Id = Guid.Parse("9fa5f7d5-c511-4f9d-b014-9b0860db1a84"), Type = TextBlockType.Enumeration, Text = "Water Elemental 40 feet, swim 80 feet; resistance 10 to fire; Vortex (aura, water) 30 feet. Water within the aura that is part of the same body of water you occupy is difficult terrain for Swimming creatures that don�t have the water trait; Melee [one-action] wave (reach 25 feet), Damage 3d12+18 bludgeoning plus Push or Pull 10 feet; Ranged [one-action] water spout (range increment 60 feet), Damage 4d8+6 bludgeoning." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("a5b60116-b97e-4be6-bb31-49bb790eb6f4"), Traits.Instances.Polymorph.ID);
            builder.Add(Guid.Parse("27a807f7-d63a-4472-80b8-39e979c049d6"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("051c22aa-1a97-4d68-817c-fdeb320d82f3"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 101
            };
        }
    }
}
