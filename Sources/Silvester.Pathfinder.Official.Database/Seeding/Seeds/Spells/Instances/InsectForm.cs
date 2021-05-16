using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class InsectForm : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Insect Form",
                Level = 3,
                IsDismissable = true,
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You envision a simple bug and transform into a Medium animal battle form. When you cast this spell, choose ant, beetle, centipede, mantis, scorpion, or spider. You can decide the specific type of animal (such as such as a ladybug or scarab for beetle), but this has no effect on the form’s Size or statistics. While in this form, you gain the animal trait. You can Dismiss this spell." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You gain the following statistics and abilities regardless of which battle form you choose:" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "AC = 18 + your level. Ignore your armor’s check penalty and Speed reduction." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "10 temporary Hit Points." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Low-light vision." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "One or more attacks specific to the battle form you choose, which are the only attacks you can use. You’re trained with them. Your attack modifier is +13, and your damage bonus is +2. These attacks are Strength based (for the purpose of the enfeebled condition). If your unarmed attack modifier is higher, you can use it instead." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Athletics modifier of +13, unless your own is higher." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You also gain specific abilities based on the form you choose:" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Ant - Speed 30 feet, climb Speed 30 feet; Melee [one-action] mandibles, Damage 2d6 bludgeoning." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Beetle - Speed 25 feet; Melee [one-action] mandibles, Damage 2d10 bludgeoning." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Centipede - Speed 25 feet, climb Speed 25 feet; darkvision; Melee [one-action] mandibles, Damage 1d8 piercing plus 1d4 persistent poison." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Mantis - Speed 40 feet; imprecise scent 30 feet; Melee [one-action] foreleg, Damage 2d8 bludgeoning." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Scorpion - Speed 40 feet; darkvision, imprecise tremorsense 60 feet; Melee [one-action] stinger, Damage 1d8 piercing plus 1d4 persistent poison; Melee [one-action] pincer (agile), Damage 1d6 bludgeoning." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Spider - Speed 25 feet, climb Speed 25 feet; darkvision; Melee [one-action] fangs, Damage 1d6 piercing plus 1d4 persistent poison; Ranged [one-action] web (range increment 20 feet), Damage entangles the target for 1 round." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your battle form is Large, and your attacks have 10-foot reach. You must have enough space to expand into or the spell is lost. You instead gain 15 temporary HP, attack modifier +16, damage bonus +6, and Athletics +16." }
                }
            }; 
            
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your battle form is Huge, and your attacks have 15-foot reach. You must have enough space to expand into or the spell is lost. You instead gain 20 temporary HP, attack modifier +18, damage bonus +2 and double damage dice (including persistent damage), and Athletics +20." }
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
            yield return Traits.Instances.Polymorph.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 346
            };
        }
    }
}
