using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DinosaurFormSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Transmutation";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("55780227-9986-4a2e-aa35-93a105314818"),
                Name = "Dinosaur Form",
                Description = "You channel the primal forces of nature to transform into a Large animal battle form, specifically that of a powerful and terrifying dinosaur. You must have space to expand or the spell is lost. When you cast this spell, choose ankylosaurus, brontosaurus, deinonychus, stegosaurus, triceratops, or tyrannosaurus. You can decide the specific type of animal, but this has no effect on the form’s Size or statistics. While in this form, you gain the animal and dinosaur traits. You can Dismiss the spell.",
                Level = 4,
                Duration = "1 minute"
            };
        }

        public override IEnumerable<SpellDetailBlock> GetSpellDetailBlocks()
        {
            yield return new SpellDetailBlock { Id = Guid.Parse("d6d57c2a-5593-4664-a1ce-669c612f62ca"), Text = "You gain the following statistics and abilities regardless of which battle form you choose:" };
            yield return new SpellDetailBlock { Id = Guid.Parse("53e6b7c7-4384-4ac0-b0df-5a786b6016cb"), Text = "- AC = 18 + your level. Ignore your armor’s check penalty and Speed reduction." };
            yield return new SpellDetailBlock { Id = Guid.Parse("5a80550b-1451-46d0-b80a-a28bc7fbdca5"), Text = "- 15 temporary Hit Points." };
            yield return new SpellDetailBlock { Id = Guid.Parse("f8d811ef-2e56-4548-9127-c1ded8842548"), Text = "- Low-light vision and imprecise scent 30 feet." };
            yield return new SpellDetailBlock { Id = Guid.Parse("ce26e35f-f33b-4e20-bf3a-1e1d58bb2802"), Text = "- One or more unarmed melee attacks specific to the battle form you choose, which are the only attacks you can use. You’re trained with them. Your attack modifier is +16, and your damage bonus is +9. These attacks are Strength based (for the purpose of the enfeebled condition, for example). If your unarmed attack modifier is higher, you can use it instead." };
            yield return new SpellDetailBlock { Id = Guid.Parse("d09af233-4775-4202-a171-23a8b3489dd9"), Text = "- Athletics modifier of +18, unless your own is higher." };
            yield return new SpellDetailBlock { Id = Guid.Parse("4772e504-4fd7-45fb-a47b-8693e6e2fdd2"), Text = "You also gain specific abilities based on the form you choose:" };
            yield return new SpellDetailBlock { Id = Guid.Parse("7c9dd7f8-02bd-4213-affe-ae981c11b182"), Text = "- Ankylosaurus: Speed 25 feet; Melee [one-action] tail (backswing, reach 10 feet), Damage 2d6 bludgeoning; Melee [one-action] foot, Damage 2d6 bludgeoning." };
            yield return new SpellDetailBlock { Id = Guid.Parse("451a5567-b1ed-4573-84d6-abd04ee44351"), Text = "- Brontosaurus: Speed 25 feet; Melee [one-action] tail (reach 15 feet), Damage 2d6 bludgeoning; Melee [one-action] foot, Damage 2d8 bludgeoning." };
            yield return new SpellDetailBlock { Id = Guid.Parse("fcd2be86-8f04-4d01-bbda-ebea7dec2614"), Text = "- Deinonychus: Speed 40 feet; Melee [one-action] talon (agile), Damage 2d4 piercing plus 1 persistent bleed; Melee [one-action] jaws, Damage 1d10 piercing." };
            yield return new SpellDetailBlock { Id = Guid.Parse("5c1d6d32-a8a9-4d35-8a55-a75492ce165e"), Text = "- Stegosaurus: Speed 30 feet; Melee [one-action] tail (reach 10 feet), Damage 2d8 piercing." };
            yield return new SpellDetailBlock { Id = Guid.Parse("59abdf72-d40a-4b6c-93d2-2a91bb5e4784"), Text = "- Triceratops: Speed 30 feet; Melee [one-action] horn, Damage 2d8 piercing, plus 1d6 persistent bleed on a critical hit; Melee [one-action] foot, Damage 2d6 bludgeoning." };
            yield return new SpellDetailBlock { Id = Guid.Parse("151544d1-c8dd-4dfe-99de-643f7f4476a9"), Text = "- Tyrannosaurus: Speed 30 feet; Melee [one-action] jaws (deadly, reach 10 feet), Damage 1d12 piercing; Melee [one-action] tail (reach 10 feet), Damage 1d10 bludgeoning." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening { Id = Guid.Parse("2f7a2dd1-f158-490c-9ffe-b67b3a085a5c"), Level = 5, Description = "Your battle form is Huge and your attacks have 15-foot reach, or 20-foot reach if they started with 15-foot reach. You instead gain 20 temporary HP, an attack modifier of +18, a damage bonus of +6, double the damage dice, and Athletics +21." };
            yield return new SpellHeightening { Id = Guid.Parse("a7a1d25e-fd89-4602-8322-e796cc091afd"), Level = 7, Description = "Your battle form is Gargantuan and your attacks have 20-foot reach, or 25-foot reach if they started with 15-foot reach. You instead gain AC = 21 + your level, 25 temporary HP, an attack modifier of +25, a damage bonus of +15, double the damage dice, and Athletics +25." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Primal";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Polymorph";
            yield return "Transmutation";
        }
    }
}
