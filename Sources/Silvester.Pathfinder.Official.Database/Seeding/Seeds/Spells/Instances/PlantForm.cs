using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class PlantForm : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Plant Form",
                Level = 5,
                Duration = "1 minute.",
                IsDismissable = true,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Taking inspiration from verdant creatures, you transform into a Large plant battle form. You must have space to expand into or the spell is lost. When you cast this spell, choose arboreal, flytrap, or shambler. You can substitute a similar specific plant to turn into (such as a pitcher plant instead of a flytrap), but this has no effect on the form’s Size or statistics. While in this form, you gain the plant trait. You can Dismiss the spell." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You gain the following statistics and abilities regardless of which battle form you choose:" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "AC = 19 + your level. Ignore your armor’s check penalty and Speed reduction." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "12 temporary Hit Points." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Resistance 10 to poison." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Low-light vision." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "One or more unarmed melee attacks specific to the battle form you choose, which are the only attacks you can use. You’re trained with them. Your attack modifier is +17, and your damage bonus is +11. These attacks are Strength based (for the purpose of the enfeebled condition, for example). If your unarmed attack modifier is higher, you can use it instead." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Athletics modifier of +19, unless your own modifier is higher." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You also gain specific abilities based on the type of plant you choose:" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Arboreal - Speed 30 feet; Melee [one‑action] branch (reach 15 feet), Damage 2d10 bludgeoning; Melee [one‑action] foot, Damage 2d8 bludgeoning; you can speak in this form, but you still can’t Cast a Spell or supply verbal components." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Flytrap - Speed 15 feet; resistance 10 to acid; Melee [one‑action] leaf (reach 10 feet), Damage 2d8 piercing, and you can spend an action after a hit to Grab the target." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Shambler - Speed 20 feet, swim Speed 20 feet; resistance 10 to electricity; Melee [one‑action] vine (reach 15 feet), Damage 2d8 slashing." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""), 
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your battle form is Huge, and the reach of your attacks increases by 5 feet. You instead gain AC = 22 + your level, 24 temporary HP, attack modifier +21, damage bonus +16, and Athletics +22." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Plant.ID;
            yield return Traits.Instances.Polymorph.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 358
            };
        }
    }
}
