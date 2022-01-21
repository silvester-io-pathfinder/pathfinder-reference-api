using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DragonForm : Template
    {
        public static readonly Guid ID = Guid.Parse("13754f33-7150-46a1-adaf-7e9eaaf147d2");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Dragon Form",
                Level = 6,
                IsDismissable = true,
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7e89d29f-4afa-45ad-b724-f7421e49e4d0"), Type = TextBlockType.Text, Text = "Calling upon powerful transformative magic, you gain a Large dragon battle form. You must have space to expand or the spell is lost. When you cast this spell, choose one type of chromatic or metallic dragon. While in this form, you gain the dragon trait. You have hands in this battle form and can take manipulate actions. You can Dismiss the spell." };
            yield return new TextBlock { Id = Guid.Parse("4be6ccab-950d-42ad-9198-1ddcbdba496b"), Type = TextBlockType.Text, Text = "You gain the following statistics and abilities regardless of which battle form you choose:" };
            yield return new TextBlock { Id = Guid.Parse("3de57955-8442-48c1-99c4-bdd80b874202"), Type = TextBlockType.Enumeration, Text = "AC = 18 + your level. Ignore your armor's check penalty and Speed reduction." };
            yield return new TextBlock { Id = Guid.Parse("51faf1cb-f741-43cf-85ca-92e1d938d3fb"), Type = TextBlockType.Enumeration, Text = "10 temporary Hit Points." };
            yield return new TextBlock { Id = Guid.Parse("04867e4b-307e-4cd9-add2-6b300f4458f0"), Type = TextBlockType.Enumeration, Text = "Speed 40 feet, fly Speed 100 feet." };
            yield return new TextBlock { Id = Guid.Parse("c64bea22-c15d-4875-8c1f-aac233ffeaee"), Type = TextBlockType.Enumeration, Text = "Resistance 10 against the damage type of your breath weapon(see below)." };
            yield return new TextBlock { Id = Guid.Parse("6a3eff7e-e769-49a2-9a08-4f830ed0f215"), Type = TextBlockType.Enumeration, Text = "Darkvision and imprecise scent 60 feet." };
            yield return new TextBlock { Id = Guid.Parse("a7604574-4a30-495a-bc3c-3e87e2db3ad1"), Type = TextBlockType.Enumeration, Text = "One or more unarmed melee attacks specific to the battle form you choose, which are the only attacks you can use. You're trained with them. Your attack modifier is +22, and your damage bonus is +6. These attacks are Strength based (for the purpose of the enfeebled condition, for example). If your unarmed attack modifier is higher, you can use it instead. See below for more on these attacks." };
            yield return new TextBlock { Id = Guid.Parse("3fc36139-62f3-4b07-b63e-d3883f161c04"), Type = TextBlockType.Enumeration, Text = "Athletics modifier of +23, unless your own modifier is higher." };
            yield return new TextBlock { Id = Guid.Parse("64973dc5-5633-4745-896c-415c5a7e82e5"), Type = TextBlockType.Text, Text = "Breath Weapon [two-actions] (arcane, evocation) The shape, damage, and damage type of your breath weapon depend on your specific dragon form (see below). A creature in the area attempts a basic save against your spell DC. This is a Reflex save unless stated otherwise in the special ability description for your specific dragon form. Once activated, your breath weapon can't be used again for 1d4 rounds. Your breath weapon has the trait corresponding to the type of damage it deals." };
            yield return new TextBlock { Id = Guid.Parse("c36f0655-dd63-4aca-99fd-3978ca6c37fc"), Type = TextBlockType.Text, Text = "You also gain specific abilities based on the type of dragon:" };
            yield return new TextBlock { Id = Guid.Parse("c3082737-85e4-4c28-96e5-87214eb79995"), Type = TextBlockType.Enumeration, Text = "Black - Swim Speed 60 feet; Melee [one-action] jaws, Damage 2d12 piercing plus 2d6 acid; Melee[one - action] claw(agile), Damage 3d10 slashing; Melee [one-action] tail (reach 10 feet), Damage 3d10 bludgeoning; Melee [one-action] horns (reach 10 feet), Damage 3d8 piercing; breath weapon 60-foot line, 11d6 acid." };
            yield return new TextBlock { Id = Guid.Parse("fbc4d94d-7195-48bf-8198-61fa87cb535c"), Type = TextBlockType.Enumeration, Text = "Blue - Burrow Speed 20 feet; Melee [one-action] jaws, Damage 2d10 piercing plus 1d12 electricity; Melee [one-action] claw (agile), Damage 3d10 slashing; Melee [one-action] tail (reach 10 feet), Damage 3d10 bludgeoning; Melee [one-action] horns (reach 10 feet), Damage 3d8 piercing; breath weapon 80-foot line, 6d12 electricity." };
            yield return new TextBlock { Id = Guid.Parse("e581b646-3ed1-4e2a-a259-02441b14eef0"), Type = TextBlockType.Enumeration, Text = "Green - Swim Speed 40 feet, ignores difficult terrain from non-magical foliage; Melee [one-action] jaws, Damage 2d12 piercing plus 2d6 poison; Melee [one-action] claw (agile), Damage 3d10 slashing; Melee [one-action] tail (reach 10 feet), Damage 3d10 bludgeoning; Melee [one-action] horns (reach 10 feet), Damage 3d8 piercing; breath weapon 30-foot cone, 10d6 poison (Fortitude save instead of Reflex)." };
            yield return new TextBlock { Id = Guid.Parse("6889f1d0-db09-46ed-a916-59c42f369592"), Type = TextBlockType.Enumeration, Text = "Red - Ignore concealed from smoke; Melee [one-action] jaws, Damage 2d12 piercing plus 2d6 fire; Melee [one-action] claw (agile), Damage 4d6 slashing; Melee [one-action] tail (reach 10 feet), Damage 3d10 bludgeoning; Melee [one-action] wing (reach 10 feet), Damage 3d8 bludgeoning; breath weapon 30-foot cone, 10d6 fire." };
            yield return new TextBlock { Id = Guid.Parse("a6311062-79c8-4662-8b92-c8785cb6b949"), Type = TextBlockType.Enumeration, Text = "White - Climb Speed 25 feet on ice only; Melee [one-action] jaws, Damage 3d6 piercing plus 2d6 cold; Melee [one-action] claw (agile), Damage 3d10 slashing; Melee [one-action] tail (reach 10 feet), Damage 3d10 bludgeoning; breath weapon 30-foot cone, 10d6 cold." };
            yield return new TextBlock { Id = Guid.Parse("33dd751e-72d6-4a6c-97a9-64368eb5aeb6"), Type = TextBlockType.Enumeration, Text = "Brass - Burrow Speed 20 feet; Melee [one-action] jaws, Damage 3d8 piercing plus 2d4 fire; Melee [one-action] claw (agile), 3d10 slashing; Melee [one-action] tail (reach 10 feet), Damage 3d10 bludgeoning; Melee [one-action] spikes (reach 10 feet), Damage 3d8 piercing; breath weapon 60-foot line, 15d4 fire." };
            yield return new TextBlock { Id = Guid.Parse("3b886593-72c7-41b2-8fde-38e642b2befc"), Type = TextBlockType.Enumeration, Text = "Bronze - Swim Speed 40 feet; Melee [one-action] jaws, Damage 2d10 piercing plus 1d12 electricity; Melee [one-action] claw (agile), Damage 3d10 slashing; Melee [one-action] tail (reach 10 feet), Damage 3d10 bludgeoning; Melee [one-action] wing (reach 10 feet), Damage 3d8 slashing; breath weapon 80-foot line, 6d12 electricity." };
            yield return new TextBlock { Id = Guid.Parse("40bc5081-e54f-4419-afff-690e3c887141"), Type = TextBlockType.Enumeration, Text = "Copper - climb Speed 25 feet on stone only; Melee [one-action] jaws, Damage 2d12 piercing plus 2d6 acid; Melee [one-action] claw (agile), Damage 3d10 slashing; Melee [one-action] tail (reach 10 feet), Damage 3d10 bludgeoning; Melee [one-action] wing (reach 10 feet), Damage 3d8 bludgeoning; breath weapon 60-foot line, 10d6 acid." };
            yield return new TextBlock { Id = Guid.Parse("a26fecc8-36f4-4f3f-8186-e8b979223e26"), Type = TextBlockType.Enumeration, Text = "Gold - Swim Speed 40 feet; Melee [one-action] jaws, Damage 2d12 piercing plus 2d6 fire; Melee [one-action] claw (agile), Damage 4d6 slashing; Melee [one-action] tail (reach 10 feet), Damage 3d10 bludgeoning; Melee [one-action] horns (reach 10 feet), Damage 3d8 piercing; breath weapon 30-foot cone, 6d10 fire." };
            yield return new TextBlock { Id = Guid.Parse("1e1ef312-f8bb-4fac-9edf-52ca4dcdab5b"), Type = TextBlockType.Enumeration, Text = "Silver - Cloud walk; Melee [one-action] jaws, Damage 2d12 piercing plus 2d6 cold; Melee [one-action] claw (agile), Damage 3d10 slashing; Melee [one-action] tail (reach 10), Damage 3d10 bludgeoning; breath weapon 30-foot cone, 8d8 cold." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("c0985c4b-fba3-43b5-8670-06ee41030e2e"), 
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("8353dcbf-0ebd-4db8-82a2-55b4ae13c516"), Type = TextBlockType.Text, Text = "Your battle form is Huge, you gain a +20-foot status bonus to your fly Speed, and your attacks have 10-foot reach (or 15-foot reach if they previously had 10-foot reach). You instead gain AC = 21 + your level, 15 temporary HP, an attack modifier of +28, a damage bonus of +12, Athletics +28, and a +14 status bonus to breath weapon damage." }
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("55753734-b833-4fda-8511-b5bcad33918c"), Traits.Instances.Polymorph.ID);
            builder.Add(Guid.Parse("4a752f0f-bc58-4b8a-9db4-649195e51591"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("833a70f2-a0c1-468f-8020-90e2ae769fd5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 332
            };
        }
    }
}
