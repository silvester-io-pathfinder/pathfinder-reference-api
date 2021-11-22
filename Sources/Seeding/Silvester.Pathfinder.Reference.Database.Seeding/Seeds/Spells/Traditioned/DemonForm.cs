using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DemonForm : Template
    {
        public static readonly Guid ID = Guid.Parse("10436483-a4b0-4ed2-a21b-2fb180c202d8");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Demon Form",
                Level = 6,
                Duration = "1 minute.",
                IsDismissable = true,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a2a3ee90-616a-47be-ac34-483e07450acc"), Type = TextBlockType.Text, Text = "You corrupt yourself with the sin of the Abyss, transforming into a Medium demon battle form. When you cast this spell, choose babau, hezrou, nabasu, or vrock. If you choose hezrou, the battle form is Large and you must have enough space to expand into or the spell is lost. While in this form, you gain the demon and fiend traits. You have hands in this battle form and can use manipulate actions. You can Dismiss the spell." };
            yield return new TextBlock { Id = Guid.Parse("dc33c7d8-7136-486f-b400-0e8dee162b93"), Type = TextBlockType.Text, Text = "You gain the following statistics and abilities regardless of the form that you choose:" };
            yield return new TextBlock { Id = Guid.Parse("61a28aaf-db14-4e0f-8804-0665e700d06d"), Type = TextBlockType.Enumeration, Text = "AC = 20 + your level. Ignore your armor check�s penalty and Speed reduction." };
            yield return new TextBlock { Id = Guid.Parse("60b0fdae-0032-4c07-8b76-8c416641bad8"), Type = TextBlockType.Enumeration, Text = "30 temporary Hit Points, weakness 5 to cold iron, and weakness 5 to good." };
            yield return new TextBlock { Id = Guid.Parse("5884986b-33f5-461c-b995-d64d499711aa"), Type = TextBlockType.Enumeration, Text = "Darkvision." };
            yield return new TextBlock { Id = Guid.Parse("6c7ee1a7-74bd-47d0-b8a9-19dd74b06d1c"), Type = TextBlockType.Enumeration, Text = "One or more attacks specific to the battle form you use. You�re trained with them. Your attack modifier is +22, and you use the listed damage. These attacks are Strength based (for the purpose of the enfeebled condition, for example). If your attack modifier is higher for the given unarmed attack or weapon, you can use it instead." };
            yield return new TextBlock { Id = Guid.Parse("51f79c21-2031-4853-9971-c16db49e2de3"), Type = TextBlockType.Enumeration, Text = "Athletics modifier of +23, unless your own modifier is higher." };
            yield return new TextBlock { Id = Guid.Parse("410d37bc-42ae-4333-aac4-1315f48ca975"), Type = TextBlockType.Text, Text = "You also gain specific abilities based on the type of demon you choose:" };
            yield return new TextBlock { Id = Guid.Parse("d5112987-0501-4f37-8a5a-635c76ee4005"), Type = TextBlockType.Enumeration, Text = "Babau - Speed 25 feet; Melee [one-action] longspear (reach 10 feet), Damage 2d8+10 piercing plus 1d6 evil; Melee [one-action] jaws, Damage 2d10 piercing plus 1d6 evil; Melee [one-action] claw (agile), Damage 2d4 slashing plus 1d6 evil; all Strikes deal 2d6 additional precision damage to flatfooted creatures." };
            yield return new TextBlock { Id = Guid.Parse("33217510-f6c3-44db-a1bc-0087976604b9"), Type = TextBlockType.Enumeration, Text = "Hezrou - Speed 30 feet, swim 30 feet; Melee [one-action] jaws (reach 10 feet), Damage 2d12+10 piercing plus 1d6 evil, and you can spend an action after a hit to Grab the target; Melee [one-action] claw (agile, reach 10 feet), Damage 2d8 slashing plus 1d6 evil." };
            yield return new TextBlock { Id = Guid.Parse("c4944a2b-665e-4256-bfbb-7fc25b5ee722"), Type = TextBlockType.Enumeration, Text = "Nabasu - Speed 25 feet, fly 40 feet; Melee [one-action] jaws, Damage 2d10+10 piercing plus 1d6 evil; Melee [one-action] claw (agile), Damage 2d6 slashing plus 1d6 evil." };
            yield return new TextBlock { Id = Guid.Parse("f67a25e9-241f-43c5-9eab-d1008e1afec5"), Type = TextBlockType.Enumeration, Text = "Vrock - Speed 25 feet, fly 35 feet; resistance 10 to electricity; Melee [one-action] beak, Damage 2d8+10 piercing plus 1d6 evil; Melee [one-action] claw (agile), Damage 2d6 slashing plus 1d6 evil; Melee [one-action] talon (agile), Damage 2d6 slashing plus 1d6 evil." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Chaotic.ID;
            yield return Traits.Instances.Evil.ID;
            yield return Traits.Instances.Polymorph.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("43f7e302-5123-4924-93e7-acf5a6d47ef4"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 99
            };
        }
    }
}
