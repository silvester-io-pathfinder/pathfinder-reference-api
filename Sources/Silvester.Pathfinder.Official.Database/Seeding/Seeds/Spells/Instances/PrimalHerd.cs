using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class PrimalHerd : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Primal Herd",
                Level = 10,
                Range = "30 feet.",
                IsDismissable = true,
                Duration = "1 minute.",
                Targets = "You and up to 5 willing targets.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Summoning the power of the natural world, you transform the targets into a herd of mammoths, and they each assume a Huge battle form. Each target must have enough space to expand into or the spell fails for that target. Each target gains the animal trait. Each target can Dismiss the spell’s effects on themself. Each target gains the following while transformed:" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "AC = 22 + the target’s level. Ignore any armor check penalty and Speed reduction." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "20 temporary Hit Points." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Speed 40 feet." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Low-light vision." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "The following unarmed melee attacks, which are the only attacks the target can use. They’re trained with them. When attacking with these attacks, the target uses their attack modifier with the proficiency and item bonuses of their most favorable weapon or unarmed Strike, and the damage is listed for each attack. These attacks are Strength based (for the purpose of the enfeebled condition, for example). If the target’s unarmed attack modifier is higher, they can use it instead. Melee [one‑action] tusk (reach 15 feet), Damage 4d8+19 piercing; Melee [one‑action] trunk (agile, reach 15 feet), Damage 4d6+16 bludgeoning; Melee [one‑action] foot (agile, reach 15 feet), Damage 4d6+13 bludgeoning." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Athletics modifier of +30, unless the target’s own modifier is higher." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Trample [three‑actions] You move up to twice your Speed and move through the space of Large or smaller creatures, trampling each creature whose space you enter. A trampled creature takes damage from its foot Strike based on a basic Reflex save (DC = 19 + the target’s level)." };
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
            yield return Traits.Instances.Morph.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 359
            };
        }
    }
}
