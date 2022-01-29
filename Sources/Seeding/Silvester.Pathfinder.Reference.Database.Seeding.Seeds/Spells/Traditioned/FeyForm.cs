using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class FeyForm : Template
    {
        public static readonly Guid ID = Guid.Parse("3012a6d6-54da-4698-a43f-8db7e13526e3");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Fey Form",
                Level = 4,
                Duration = "1 minute.",
                IsDismissable = true,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ef98fc03-a766-4298-a513-6190182671c7"), Type = TextBlockType.Text, Text = "Channeling the mischievous fey, you transform into a fey battle form, which is Medium unless stated otherwise. When you cast this spell, choose dryad, elananx, naiad, redcap, or unicorn. If you choose unicorn, the battle form is Large and you must have space to expand or the spell is lost. While in this form, you gain the fey trait. Unless you choose elananx or unicorn, you have hands in this battle form and can use manipulate actions. You can Dismiss the spell." };
            yield return new TextBlock { Id = Guid.Parse("893f5ec3-fcbb-42af-aa39-664652d9a050"), Type = TextBlockType.Text, Text = "You gain the following statistics and abilities regardless of the form that you choose:" };
            yield return new TextBlock { Id = Guid.Parse("4ad2a40f-554e-41cf-b636-0cc04d002c85"), Type = TextBlockType.Enumeration, Text = "AC = 19 + your level. Ignore your armor's check penalty and Speed reduction." };
            yield return new TextBlock { Id = Guid.Parse("8ce02414-9ece-4e43-bfef-7dab9beae876"), Type = TextBlockType.Enumeration, Text = "15 temporary Hit Points and weakness 5 to cold iron." };
            yield return new TextBlock { Id = Guid.Parse("887fee56-4279-47fb-b26a-73946fd0afe2"), Type = TextBlockType.Enumeration, Text = "Low-light vision." };
            yield return new TextBlock { Id = Guid.Parse("41c64e60-2471-4e40-84e4-6f2bebf963c4"), Type = TextBlockType.Enumeration, Text = "One or more unarmed melee attacks specific to the battle form you choose, which are the only attacks you can use. you're trained with them. Your attack modifier is +16, and you use the listed damage. These attacks are Dexterity based. If your attack modifier is higher for the given unarmed attack or weapon, you can use it instead." };
            yield return new TextBlock { Id = Guid.Parse("4096ccda-141e-4579-a14e-01e630a32066"), Type = TextBlockType.Enumeration, Text = "Acrobatics modifiers of +16, unless your own modifier is higher." };
            yield return new TextBlock { Id = Guid.Parse("f5e46e31-c752-42bb-8265-dc59b90fe725"), Type = TextBlockType.Text, Text = "You also gain specific abilities based on the type of fey:" };
            yield return new TextBlock { Id = Guid.Parse("17df771f-564d-4952-814e-39a08a181546"), Type = TextBlockType.Enumeration, Text = "Dryad The temporary HP gained increases to 30; Speed 25 feet; weakness 5 to fire; Melee [one-action] branch, Damage 1d12+8 bludgeoning." };
            yield return new TextBlock { Id = Guid.Parse("586b5ab0-d882-464f-87e6-3deca2e6b26d"), Type = TextBlockType.Enumeration, Text = "Elananx Speed 30 feet; resistance 5 to fire; Melee [one-action] jaws, Damage 1d6+8 piercing plus 1d6 fire; Melee [one-action] claw (agile), Damage 1d6 slashing." };
            yield return new TextBlock { Id = Guid.Parse("bfdc6a74-a0e0-46f0-abd8-db0206cfbb12"), Type = TextBlockType.Enumeration, Text = "Naiad Speed 25 feet, swim 25 feet; resistance 5 to fire; Melee [one-action] aqueous fist (water), Damage 1d8+8 bludgeoning." };
            yield return new TextBlock { Id = Guid.Parse("84d1bbee-0933-4f0b-9e9f-34d2aca73fe4"), Type = TextBlockType.Enumeration, Text = "Redcap Speed 40 feet; Size Small; Melee [one-action] scythe (deadly d10, trip), Damage 1d10+8 slashing; Melee [one-action] boot (agile, versatile B), Damage 1d6 piercing." };
            yield return new TextBlock { Id = Guid.Parse("d6f8c303-e0c6-4945-91ac-8a81ad2308ef"), Type = TextBlockType.Enumeration, Text = "Unicorn gain the beast trait in addition to fey; Speed 40 feet; resistance 5 to poison; Size Large; Melee [one-action] horn, Damage 1d10+8 piercing plus 1 good; Melee [one-action] hoof (agile), Damage 1d8 bludgeoning; all Strikes have the effects of a ghost touch property rune." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("77ee1a9b-9693-4312-94c6-276a2be581ba"), Traits.Instances.Polymorph.ID);
            builder.Add(Guid.Parse("d1e4f75d-56db-4038-a4e0-c44ad5301565"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("12a0e822-e1f2-4b5a-b838-8ea128b1088f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 105
            };
        }
    }
}
