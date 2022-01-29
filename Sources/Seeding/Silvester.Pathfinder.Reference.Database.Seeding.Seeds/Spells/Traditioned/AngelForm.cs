using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class AngelForm : Template
    {
        public static readonly Guid ID = Guid.Parse("60a12ca5-4ea0-469b-a8a3-bb923d12e78d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Angel Form",
                Level = 7,
                Duration = "1 minute.",
                IsDismissable = true,
                IsSavingThrowBasic = false,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("64f536f8-039e-4c02-8964-6763ef5a9750"), Type = TextBlockType.Text, Text = "Invoking the celestial realms, you transform into a Medium angel battle form. When you cast this spell, choose balisse, choral, monadic deva, or movanic deva. The battle form is Small if you choose choral. While in this form, you gain the angel and celestial traits. You have hands in this battle form and can use manipulate actions. You can Dismiss the spell." };
            yield return new TextBlock { Id = Guid.Parse("d2e457f5-a8a6-4aa3-83b6-46fb4df1018e"), Type = TextBlockType.Text, Text = "You gain the following statistics and abilities regardless of the form that you choose:" };
            yield return new TextBlock { Id = Guid.Parse("1c592625-4450-47af-a9a7-3181a4b3968c"), Type = TextBlockType.Enumeration, Text = "AC = 22 + your level. Ignore your armor check's penalty and Speed reduction." };
            yield return new TextBlock { Id = Guid.Parse("5638e70d-a470-4fad-b240-8d0fe6e1facd"), Type = TextBlockType.Enumeration, Text = "40 temporary Hit Points and weakness 10 to evil damage." };
            yield return new TextBlock { Id = Guid.Parse("325f6989-3821-4133-b786-eeefd99d284a"), Type = TextBlockType.Enumeration, Text = "Darkvision." };
            yield return new TextBlock { Id = Guid.Parse("c9df2298-79a5-4344-8426-d08810e748d1"), Type = TextBlockType.Enumeration, Text = "One or more attacks specific to the battle form you choose. you're trained with them. Your attack modifier is +25, and you use the listed damage. Melee attacks are Strength based (for the purpose of the enfeebled condition, for example), and ranged attacks are Dexterity based. If your attack modifier is higher for the given unarmed attack or weapon, you can use it instead." };
            yield return new TextBlock { Id = Guid.Parse("7b59914c-1cdb-495c-8c74-e94e28a874c3"), Type = TextBlockType.Enumeration, Text = "Athletics modifier of +25, unless your own modifier is higher." };
            yield return new TextBlock { Id = Guid.Parse("b3164c0d-5875-4708-b05a-07d7487aa37a"), Type = TextBlockType.Text, Text = "You also gain specific abilities based on the type of angel you choose:" };
            yield return new TextBlock { Id = Guid.Parse("85e569c0-b0cc-4417-8873-93a94993f412"), Type = TextBlockType.Enumeration, Text = "Balisse - Speed 30 feet, fly 40 feet; Perception modifier of +26 to detect lies and illusions unless your own modifier is higher; Melee [one-action] scimitar (forceful, sweep), Damage 2d6+12 slashing plus 1d6 fire and 1d6 good." };
            yield return new TextBlock { Id = Guid.Parse("c5cf075e-edfd-43e8-becb-af961ecf0dd9"), Type = TextBlockType.Enumeration, Text = "Choral - Speed 30 feet, fly 40 feet; +1 status bonus to AC and saves against sonic and auditory; Melee [one-action] fist (agile), Damage 2d6+12 bludgeoning plus 1d6 good; Ranged [one-action] piercing hymn (range 90 feet), Damage 1d6+12 sonic plus 1d6 good, and deafened for 1 round on a critical hit." };
            yield return new TextBlock { Id = Guid.Parse("94c57bc3-bc9e-4d66-9362-6ccaa4654a78"), Type = TextBlockType.Enumeration, Text = "Monadic Deva - Speed 30 feet, fly 40 feet; +2 status bonus on saves against death effects and effects that manipulate souls; Melee [one-action] holy mace (shove), Damage 2d6+12 bludgeoning plus 1d6 force and 1d6 good." };
            yield return new TextBlock { Id = Guid.Parse("20e0bc25-309a-4058-9a2c-44230351535c"), Type = TextBlockType.Enumeration, Text = "Movanic Deva - Speed 30 feet, fly 40 feet; resistance 10 to negative; Melee [one-action] bastard sword (two-hand d12), Damage 1d8+12 slashing plus 1d6 fire and 1d6 good." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("b4345736-a427-4e5c-a34d-bd074d7cede3"),
                Level = "9th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("4a66c5f2-53fc-451f-88d8-e8023d2f951e"), Type = TextBlockType.Text, Text = "Your battle form is Large. You must have space to expand, or the spell is lost. You instead gain 60 temporary Hit Points, weakness 15 to evil damage, attack modifier +30, damage bonus +20, and Athletics +33." }
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
            yield return MagicTraditions.Instances.Divine.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("e2a0b993-9d8e-4d85-944d-1ac5fcb5e8af"), Traits.Instances.Good.ID);
            builder.Add(Guid.Parse("12b82566-efc9-48ab-a006-14dcb385c130"), Traits.Instances.Polymorph.ID);
            builder.Add(Guid.Parse("a0a21475-7770-4947-aa48-7f18045189e1"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2aa67064-3612-44b8-acc0-02912f76797f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 89
            };
        }
    }
}
