using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class AerialFormSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Transmutation";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("aee1f3ae-7c4d-4032-883c-73d4d903b2d9"),
                Name = "Aerial Form",
                Description = "You harness your mastery of primal forces to reshape your body into a Medium flying animal battle form. When you cast this spell, choose bat, bird, pterosaur, or wasp. You can decide the specific type of animal (such as an owl or eagle for bird), but this has no effect on the form’s Size or statistics. While in this form, you gain the animal trait. You can Dismiss the spell.",
                IsDismissable = true,
                Duration = "1 minute.",
                Level = 4,
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening { Id = Guid.Parse("461c1a6c-d9e9-4c24-82df-9799e0001811"), Level = 5, Description = "Your battle form is Large and your fly Speed gains a +10-foot status bonus. You must have enough space to expand into or the spell is lost. You instead gain 10 temporary HP, attack modifier +18, damage bonus +8, and Acrobatics +20." };
            yield return new SpellHeightening { Id = Guid.Parse("0b4eadbc-0ed2-444c-997f-0e248309b869"), Level = 6, Description = "Your battle form is Huge, your fly Speed gains a +15-foot status bonus, and your attacks have 10-foot reach. You must have enough space to expand into or the spell is lost. You instead gain AC = 21 + your level, 15 temporary HP, attack modifier +21, damage bonus +4 and double damage dice (including persistent damage), and Acrobatics +23." };
        }

        public override IEnumerable<SpellDetailBlock> GetSpellDetailBlocks()
        {
            yield return new SpellDetailBlock { Id = Guid.Parse("887e893d-9fcc-497b-8919-8042b3cdc1ec"), Text = "You gain the following statistics and abilities regardless of which battle form you choose:" };
            yield return new SpellDetailBlock { Id = Guid.Parse("567dee10-2303-414d-98fa-56f7716db07d"), Text = "- AC = 18 + your level. Ignore your armor’s check penalty and Speed reduction." };
            yield return new SpellDetailBlock { Id = Guid.Parse("5ff96a2e-a6ea-4517-aba3-0fe377bae9d5"), Text = "- 5 temporary Hit Points." };
            yield return new SpellDetailBlock { Id = Guid.Parse("f75b792f-043d-41cf-b6a9-56f7bd20ba1f"), Text = "- Low-light vision." };
            yield return new SpellDetailBlock { Id = Guid.Parse("f70c57db-900e-463b-b89a-c2bd7fe6cf56"), Text = "- One or more unarmed melee attacks specific to the battle form you choose, which are the only attacks you can use. You’re trained with them. Your attack modifier is +16, and your damage bonus is +5. These attacks are Dexterity based (for the purpose of the clumsy condition, for example). If your attack modifier for Dexterity-based unarmed attacks is higher, you can use it instead." };
            yield return new SpellDetailBlock { Id = Guid.Parse("ebc22a9b-b423-46ad-a966-0e1681936c64"), Text = "- Acrobatics modifier of +16, unless your own modifier is higher." };
            yield return new SpellDetailBlock { Id = Guid.Parse("ee30e7f9-5884-4454-955c-1da78755dab9"), Text = "You also gain specific abilities based on the form you choose:" };
            yield return new SpellDetailBlock { Id = Guid.Parse("1aec42b4-675b-4d61-8575-0115a42e52cc"), Text = "- Bat Speed 20 feet, fly Speed 30 feet; precise echolocation 40 feet; Melee [one-action] fangs, Damage 2d8 piercing; Melee [one-action] wing (agile), Damage 2d6 bludgeoning." };
            yield return new SpellDetailBlock { Id = Guid.Parse("d96945ba-09d9-4b78-acc7-5b09c7afab4c"), Text = "- Bird Speed 10 feet, fly Speed 50 feet; Melee [one-action] beak, Damage 2d8 piercing; Melee [one-action] talon (agile), Damage 1d10 slashing." };
            yield return new SpellDetailBlock { Id = Guid.Parse("7c3a524d-46bf-4367-941d-bc97e7c55be8"), Text = "- Pterosaur Speed 10 feet, fly Speed 40 feet; imprecise scent 30 feet; Melee[one-action] beak, Damage 3d6 piercing." };
            yield return new SpellDetailBlock { Id = Guid.Parse("f34e506c-12c8-4dad-9cbf-9e543170d9f1"), Text = "- Wasp Speed 20 feet, fly Speed 40 feet; Melee [one-action] stinger, Damage 1d8 piercing plus 1d6 persistent poison." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Arcane";
            yield return "Primal";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Polymorph";
            yield return "Transmutation";
        }
    }
}
