using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ElementalForm : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Elemental Form",
                Level = 5,
                IsDismissable = true,
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You call upon the power of the planes to transform into a Medium elemental battle form. When you cast this spell, choose air, earth, fire, or water. While in this form, you gain the corresponding trait and the elemental trait. You have hands in this battle form and can take manipulate actions. You can Dismiss the spell." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You gain the following statistics and abilities regardless of which battle form you choose:" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "AC = 19 + your level. Ignore your armor’s check penalty and Speed reduction." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "10 temporary Hit Points." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Darkvision." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "One or more unarmed melee attacks specific to the battle form you choose, which are the only attacks you can use. You’re trained with them. Your attack modifier is +18, and your damage bonus is +9. These are Dexterity based (air or fire) or Strength based (earth or water). If your corresponding unarmed attack modifier is higher, you can use it instead." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Acrobatics (air or fire) or Athletics (earth or water) modifier of +20; ignore this change if your own modifier is higher." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You also gain specific abilities based on the type of elemental you choose:" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Air - fly Speed 80 feet, movement doesn’t reactions; Melee [one-action] gust, Damage 1d4 bludgeoning." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Earth - Speed 20 feet, burrow Speed 20 feet; Melee [one-action] fist, Damage 2d10 bludgeoning." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Fire - Speed 50 feet; fire resistance 10, weakness 5 to cold and 5 to water; Melee [one-action] tendril, Damage 1d8 fire plus 1d4 persistent fire." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Water - Speed 20 feet, swim Speed 60 feet; fire resistance 5; Melee [one-action] wave, Damage 1d12 bludgeoning, and you can spend an action immediately after a hit to push the target 5 feet with the effects of a successful Shove." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your battle form is Large and your attacks have 10-foot reach. You must have space to expand or the spell is lost. You instead gain AC = 22 + your level, 15 temporary HP, an attack modifier of +23, a damage bonus of +13, and Acrobatics or Athletics +23." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your battle form is Huge and your attacks have 15-foot reach. You must have space to expand or the spell is lost. You instead gain AC = 22 + your level, 20 temporary HP, an attack modifier of +25, a damage bonus of +11, double the number of damage dice (including persistent damage), and Acrobatics or Athletics +25." }
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Polymorph.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 335
            };
        }
    }
}
