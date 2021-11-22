using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DaemonForm : Template
    {
        public static readonly Guid ID = Guid.Parse("e23d6cff-7b60-4964-8b08-c7fce54757c9");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Daemon Form",
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
            yield return new TextBlock { Id = Guid.Parse("fa488103-fc15-4038-969f-c761d22e98c3"), Type = TextBlockType.Text, Text = "You infuse yourself with the corrupting death and pure malevolence of Abaddon, transforming into a Large daemon battle form. You must have enough space to expand into or the spell is lost. When you cast this spell you choose either ceustodaemon, leukodaemon, meladaemon, or piscodaemon. The battle form is Medium if you choose ceustodaemon. While in this form, you gain the daemon and fiend traits. You have hands in this battle form and can use manipulate actions. You can Dismiss the spell." };
            yield return new TextBlock { Id = Guid.Parse("60a73a3b-21d9-44ca-a912-b082c728fcc8"), Type = TextBlockType.Text, Text = "You gain the following statistics and abilities regardless of the form that you choose:" };
            yield return new TextBlock { Id = Guid.Parse("30da9c47-598c-4ef7-9fd3-1e0a74be95ad"), Type = TextBlockType.Enumeration, Text = "AC = 21 + your level. Ignore your armor check�s penalty and Speed reduction." };
            yield return new TextBlock { Id = Guid.Parse("cc10f406-ec08-4cee-b942-c728e52e6c8d"), Type = TextBlockType.Enumeration, Text = "15 temporary Hit Points and weakness 5 to good." };
            yield return new TextBlock { Id = Guid.Parse("3b8d1e29-a888-4501-9948-03ddcf2f3bd1"), Type = TextBlockType.Enumeration, Text = "A +2 status bonus to all saving throws against death effects." };
            yield return new TextBlock { Id = Guid.Parse("1fd28241-0da9-4692-a7fe-e1e4709f7eba"), Type = TextBlockType.Enumeration, Text = "Resistance 10 to poison." };
            yield return new TextBlock { Id = Guid.Parse("08b0b6ae-7ecb-4f3c-ba2a-69494bb87780"), Type = TextBlockType.Enumeration, Text = "Darkvision." };
            yield return new TextBlock { Id = Guid.Parse("23758ed0-1664-4a51-9ccd-5782bea6aa07"), Type = TextBlockType.Enumeration, Text = "One or more attacks specific to the battle form you use. You�re trained with them. Your attack modifier is +21, and you use the listed damage. These attacks are Strength based (for the purpose of the enfeebled condition, for example). If your unarmed attack modifier is higher, you can use it instead." };
            yield return new TextBlock { Id = Guid.Parse("553b2543-b124-412c-b806-ad7e3a0eed28"), Type = TextBlockType.Enumeration, Text = "Athletics modifier of +23, unless your own modifier is higher." };
            yield return new TextBlock { Id = Guid.Parse("ad9c1759-64d8-4048-9ccf-28d24b8f554a"), Type = TextBlockType.Text, Text = "You also gain specific abilities based on the type of Daemon you choose:" };
            yield return new TextBlock { Id = Guid.Parse("7f6f6a6e-56ba-4eda-b14c-2afdb0982fc2"), Type = TextBlockType.Enumeration, Text = "Ceustodaemon - Speed 25 feet; Melee [one-action] jaws (reach 10 feet), Damage 2d10+10 piercing plus 1d6 evil; Melee [one-action] claw (agile, reach 10 feet), Damage 2d6 slashing plus 1d6 evil; any successful jaws or claw Strike deals an additional 1d6 damage, and you take the same amount of damage." };
            yield return new TextBlock { Id = Guid.Parse("c5e5c81d-a422-4030-aa98-be714f3b6dcd"), Type = TextBlockType.Enumeration, Text = "Leukodaemon - Speed 25 feet, fly 40 feet; +2 status bonus to saves against diseases; Melee [one-action] jaws (reach 10 feet), Damage 2d10+10 piercing plus 1d6 evil; Melee [one-action] claw (agile, reach 10 feet), Damage 2d6 slashing plus 1d6 evil; Ranged [one-action] composite longbow (deadly d10, range increment 100 feet, volley), Damage 2d8 piercing plus 1d6 evil." };
            yield return new TextBlock { Id = Guid.Parse("dc08c83a-5695-4144-b81c-a1bedbe73e74"), Type = TextBlockType.Enumeration, Text = "Meladaemon - Speed 25 feet, fly 40 feet; Melee [one-action] jaws (reach 10 feet), Damage 2d10+10 piercing plus 1d6 evil; Melee [one-action] claw (agile, reach 10 feet), Damage 1d8 slashing plus 1d6 evil and 1d6 negative, and you can spend an action after a hit to Grab the target." };
            yield return new TextBlock { Id = Guid.Parse("5d34dd2d-f60f-45b0-9242-1a5fb7cddb1e"), Type = TextBlockType.Enumeration, Text = "Piscodaemon - Speed 25 feet, swim 40 feet; Melee [one-action] claw, Damage 2d10+10 piercing plus 1d6 evil and 1d6 persistent bleed, and you can spend an action after a hit to Grab the target; Melee [one-action] tentacle (agile), Damage 2d6 bludgeoning plus 1d6 evil and 1d6 poison." };
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
            yield return Traits.Instances.Evil.ID;
            yield return Traits.Instances.Polymorph.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4b36b019-e3b7-4ae0-ac18-26d4718c39f8"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 98
            };
        }
    }
}
