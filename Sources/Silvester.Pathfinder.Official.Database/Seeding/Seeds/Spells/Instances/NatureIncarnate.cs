using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class NatureIncarnate : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Nature Incarnate",
                Level = 10,
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The primal power of the world flows through you. You transform into an incarnation of nature, either a green man or a kaiju. Your battle form is Medium for a green man or Gargantuan (30-foot-by-30-foot space) for a kaiju. You must have enough space to expand into or the spell is lost. While in this form, you gain the plant trait (for a green man) or the beast trait (for a kaiju). You can Dismiss the spell." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You gain the following statistics and abilities regardless of which battle form you choose:" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "AC = 25 + your level. Ignore your armor’s check penalty and Speed reduction." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "30 temporary Hit Points." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Darkvision." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "One or more attacks specific to the battle form you choose, which are the only attacks you can use. You’re trained with them. Your attack modifier is +34, and you use the listed damage. These attacks are Strength based (for the purpose of the enfeebled condition, for example). If your unarmed attack modifier is higher, you can use it instead." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Athletics modifier of +36, unless your own modifier is higher." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You also gain specific abilities based on the type of incarnation you choose:" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Green Man - Speed 40 feet, climb Speed 40 feet; Melee [one‑action] vines (reach 30 feet, versatile P), Damage 6d8+12 bludgeoning; Ranged [one‑action] thorns (range 100 feet), Damage 6d6+6 piercing; Green Caress (aura, primal, transmutation) 60 feet. Enemies other than plants must succeed at a Fortitude save against your spell DC or become clumsy 1 for 1 round (clumsy 2 on a critical failure)." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Kaiju - Speed 50 feet; resistance 5 to physical damage; Melee [one‑action] jaws (reach 30 feet), Damage 6d10+10 piercing; Melee [one‑action] claws (agile, reach 30 feet), Damage 6d8+8 slashing; Melee [one‑action] foot (agile, reach 15 feet), Damage 6d6+10 bludgeoning; Unstoppable You are immune to being immobilized and ignore difficult terrain and greater difficult terrain; Trample [three‑actions] You move up to double your Speed and move through the spaces of Huge or smaller creatures, trampling each creature whose space you enter. A trampled creature takes foot damage with a basic Reflex save against your spell DC." };
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
                Page = 354
            };
        }
    }
}
