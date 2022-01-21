using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PlantForm : Template
    {
        public static readonly Guid ID = Guid.Parse("23360ea6-7814-4686-b26f-bda76ce19c8b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Plant Form",
                Level = 5,
                Duration = "1 minute.",
                IsDismissable = true,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6879e330-6450-4a93-839e-81776f601b03"), Type = TextBlockType.Text, Text = "Taking inspiration from verdant creatures, you transform into a Large plant battle form. You must have space to expand into or the spell is lost. When you cast this spell, choose arboreal, flytrap, or shambler. You can substitute a similar specific plant to turn into (such as a pitcher plant instead of a flytrap), but this has no effect on the form's Size or statistics. While in this form, you gain the plant trait. You can Dismiss the spell." };
            yield return new TextBlock { Id = Guid.Parse("1d53cf41-52a3-4b3f-b2f2-f518c55c1f84"), Type = TextBlockType.Text, Text = "You gain the following statistics and abilities regardless of which battle form you choose:" };
            yield return new TextBlock { Id = Guid.Parse("309ae535-4c4d-43de-921f-e21b5d074e94"), Type = TextBlockType.Enumeration, Text = "AC = 19 + your level. Ignore your armor's check penalty and Speed reduction." };
            yield return new TextBlock { Id = Guid.Parse("e735b9d3-7d52-4649-ba9e-24585ec37c28"), Type = TextBlockType.Enumeration, Text = "12 temporary Hit Points." };
            yield return new TextBlock { Id = Guid.Parse("045a027f-d518-46bf-86c7-05a60726148c"), Type = TextBlockType.Enumeration, Text = "Resistance 10 to poison." };
            yield return new TextBlock { Id = Guid.Parse("ea5661dc-1e85-498b-adf5-7647f5caa542"), Type = TextBlockType.Enumeration, Text = "Low-light vision." };
            yield return new TextBlock { Id = Guid.Parse("c5e8ec87-a1b1-458b-9c6c-6cd56145e0b2"), Type = TextBlockType.Enumeration, Text = "One or more unarmed melee attacks specific to the battle form you choose, which are the only attacks you can use. You're trained with them. Your attack modifier is +17, and your damage bonus is +11. These attacks are Strength based (for the purpose of the enfeebled condition, for example). If your unarmed attack modifier is higher, you can use it instead." };
            yield return new TextBlock { Id = Guid.Parse("cc10b95a-7c9e-4bdd-87b4-5e938a2f9d7e"), Type = TextBlockType.Enumeration, Text = "Athletics modifier of +19, unless your own modifier is higher." };
            yield return new TextBlock { Id = Guid.Parse("288df902-223a-4253-9322-c8af1e414ba1"), Type = TextBlockType.Text, Text = "You also gain specific abilities based on the type of plant you choose:" };
            yield return new TextBlock { Id = Guid.Parse("1b10930e-dc6e-45e6-9764-94f57c2db837"), Type = TextBlockType.Enumeration, Text = "Arboreal - Speed 30 feet; Melee [one‑action] branch (reach 15 feet), Damage 2d10 bludgeoning; Melee [one‑action] foot, Damage 2d8 bludgeoning; you can speak in this form, but you still can't Cast a Spell or supply verbal components." };
            yield return new TextBlock { Id = Guid.Parse("b00dcdfa-eb67-4d0c-bcd5-c4e0596528bd"), Type = TextBlockType.Enumeration, Text = "Flytrap - Speed 15 feet; resistance 10 to acid; Melee [one‑action] leaf (reach 10 feet), Damage 2d8 piercing, and you can spend an action after a hit to Grab the target." };
            yield return new TextBlock { Id = Guid.Parse("07974ebc-cffa-4066-9dc9-050f58436607"), Type = TextBlockType.Enumeration, Text = "Shambler - Speed 20 feet, swim Speed 20 feet; resistance 10 to electricity; Melee [one‑action] vine (reach 15 feet), Damage 2d8 slashing." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("62da1fae-888d-49a9-88cf-185357814ccd"), 
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("37705d15-be55-4aaa-ae3d-94b9a9b3fa4d"), Type = TextBlockType.Text, Text = "Your battle form is Huge, and the reach of your attacks increases by 5 feet. You instead gain AC = 22 + your level, 24 temporary HP, attack modifier +21, damage bonus +16, and Athletics +22." }
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("06cf4873-3b73-4803-a2c9-1b2707fa9b6e"), Traits.Instances.Plant.ID);
            builder.Add(Guid.Parse("2166a8cc-aa84-4222-98cf-6cb0a036f1e7"), Traits.Instances.Polymorph.ID);
            builder.Add(Guid.Parse("ae454b16-0c5e-4918-a6e7-de03b3a940fb"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7f10b0a4-a62c-44a2-9d53-f5b95ea8ae05"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 358
            };
        }
    }
}
