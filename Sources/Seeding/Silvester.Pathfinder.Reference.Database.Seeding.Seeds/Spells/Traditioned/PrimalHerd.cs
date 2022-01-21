using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PrimalHerd : Template
    {
        public static readonly Guid ID = Guid.Parse("129a3bd8-23de-40ac-98c7-1a6301fd1c22");

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
            yield return new TextBlock { Id = Guid.Parse("ac07b494-8238-4570-9054-54799c67564b"), Type = TextBlockType.Text, Text = "Summoning the power of the natural world, you transform the targets into a herd of mammoths, and they each assume a Huge battle form. Each target must have enough space to expand into or the spell fails for that target. Each target gains the animal trait. Each target can Dismiss the spell's effects on themself. Each target gains the following while transformed:" };
            yield return new TextBlock { Id = Guid.Parse("5d1d71ea-cfef-4e7e-9046-1d7de045f00b"), Type = TextBlockType.Enumeration, Text = "AC = 22 + the target's level. Ignore any armor check penalty and Speed reduction." };
            yield return new TextBlock { Id = Guid.Parse("225ada54-c1ef-4a3b-9a70-d1347d62d754"), Type = TextBlockType.Enumeration, Text = "20 temporary Hit Points." };
            yield return new TextBlock { Id = Guid.Parse("aa6d28d3-4466-426f-8458-2743e5c0dc8e"), Type = TextBlockType.Enumeration, Text = "Speed 40 feet." };
            yield return new TextBlock { Id = Guid.Parse("46a149ee-5355-44b6-b01e-5b7a00151482"), Type = TextBlockType.Enumeration, Text = "Low-light vision." };
            yield return new TextBlock { Id = Guid.Parse("f92e1b0a-72ff-415b-8c6d-7ac595e73351"), Type = TextBlockType.Enumeration, Text = "The following unarmed melee attacks, which are the only attacks the target can use. They're trained with them. When attacking with these attacks, the target uses their attack modifier with the proficiency and item bonuses of their most favorable weapon or unarmed Strike, and the damage is listed for each attack. These attacks are Strength based (for the purpose of the enfeebled condition, for example). If the target's unarmed attack modifier is higher, they can use it instead. Melee [one‑action] tusk (reach 15 feet), Damage 4d8+19 piercing; Melee [one‑action] trunk (agile, reach 15 feet), Damage 4d6+16 bludgeoning; Melee [one‑action] foot (agile, reach 15 feet), Damage 4d6+13 bludgeoning." };
            yield return new TextBlock { Id = Guid.Parse("fc3e5a7e-0848-4680-ad41-a857c673f891"), Type = TextBlockType.Enumeration, Text = "Athletics modifier of +30, unless the target's own modifier is higher." };
            yield return new TextBlock { Id = Guid.Parse("12133f1b-e9b6-468e-8ccc-44ce31982a64"), Type = TextBlockType.Enumeration, Text = "Trample [three‑actions] You move up to twice your Speed and move through the space of Large or smaller creatures, trampling each creature whose space you enter. A trampled creature takes damage from its foot Strike based on a basic Reflex save (DC = 19 + the target's level)." };
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
            builder.Add(Guid.Parse("ab123a2e-4f01-4b42-ad92-ca068863a623"), Traits.Instances.Morph.ID);
            builder.Add(Guid.Parse("26eed463-d62f-4cf4-9aa4-872258d32e8a"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d33d6965-a4a5-4d40-9502-92ae85575101"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 359
            };
        }
    }
}
