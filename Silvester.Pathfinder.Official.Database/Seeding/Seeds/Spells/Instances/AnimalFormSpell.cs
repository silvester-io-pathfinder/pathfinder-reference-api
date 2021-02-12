﻿using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class AnimalFormSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Transmutation";
        public override string SavingThrowStat => "Will";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("1facaf2c-11ad-43fc-a69c-6e18e3e81b4d"),
                Name = "Animal Form",
                Description = "You call upon primal energy to transform yourself into a Medium animal battle form. When you first cast this spell, choose ape, bear, bull, canine, cat, deer, frog, shark, or snake. You can decide the specific type of animal (such as lion or snow leopard for cat), but this has no effect on the form’s Size or statistics. While in this form, you gain the animal trait. You can Dismiss the spell.",
                Level = 2,
                Duration = "1 minute."
            };
        }

        public override IEnumerable<SpellDetailBlock> GetSpellDetailBlocks()
        {
            yield return new SpellDetailBlock { Id = Guid.Parse("300ba168-764f-491e-a447-df9f3c2f3c3c"), Text = "You gain the following statistics and abilities regardless of which battle form you choose:" };
            yield return new SpellDetailBlock { Id = Guid.Parse("861b2972-0bf6-4ac7-87cf-d7200caf3872"), Text = "- AC = 16 + your level. Ignore your armor’s check penalty and Speed reduction." };
            yield return new SpellDetailBlock { Id = Guid.Parse("ade20fbb-a1e0-4cb8-8b63-4ed7306f1427"), Text = "- 5 temporary Hit Points." };
            yield return new SpellDetailBlock { Id = Guid.Parse("a2575b6e-2f53-4c64-92ca-a2e2006809cf"), Text = "- Low-light vision and imprecise scent 30 feet." };
            yield return new SpellDetailBlock { Id = Guid.Parse("54acdc29-8944-49a8-b38b-3bd5bf590358"), Text = "- One or more unarmed melee attacks specific to the battle form you choose, which are the only attacks you can use. You’re trained with them. Your attack modifier is +9, and your damage bonus is +1. These attacks are Strength based (for the purpose of the enfeebled condition, for example). If your unarmed attack bonus is higher, you can use it instead." };
            yield return new SpellDetailBlock { Id = Guid.Parse("59c4fe59-3095-446e-b43f-34a001f7afd3"), Text = "- Athletics modifier of +9, unless your own modifier is higher." };
            yield return new SpellDetailBlock { Id = Guid.Parse("0a3de3aa-3e97-4f6b-a661-88f0f8477e82"), Text = "You also gain specific abilities based on the type of animal you choose:" };
            yield return new SpellDetailBlock { Id = Guid.Parse("c7873354-5805-4c8a-8831-1d82a30ee8ed"), Text = "- Ape Speed 25 feet, climb Speed 20 feet; Melee [one-action] fist, Damage 2d6 bludgeoning." };
            yield return new SpellDetailBlock { Id = Guid.Parse("66e1d25e-9eb7-42dc-b412-220923879e98"), Text = "- Bear Speed 30 feet; Melee [one-action] jaws, Damage 2d8 piercing; Melee [one-action] claw (agile), Damage 1d8 slashing." };
            yield return new SpellDetailBlock { Id = Guid.Parse("dcbaa11d-7b56-43d2-a72e-13ec97f14e3f"), Text = "- Bull Speed 30 feet; Melee [one-action] horn, Damage 2d8 piercing." };
            yield return new SpellDetailBlock { Id = Guid.Parse("e79c445d-4649-4cc9-b427-dbfb754c1ad3"), Text = "- Canine Speed 40 feet; Melee [one-action] jaws, Damage 2d8 piercing." };
            yield return new SpellDetailBlock { Id = Guid.Parse("46f110c3-3c5a-4319-b725-e7ea9a52528a"), Text = "- Cat Speed 40 feet; Melee [one-action] jaws, Damage 2d6 piercing; Melee[one - action] claw(agile), Damage 1d10 slashing." };
            yield return new SpellDetailBlock { Id = Guid.Parse("19cb8dc2-bef1-4622-b4e2-786de8f85b81"), Text = "- Deer Speed 50 feet; Melee [one-action] antler, Damage 2d6 piercing." };
            yield return new SpellDetailBlock { Id = Guid.Parse("b63c6577-1c20-42ef-8bf4-4fd87ec3f16a"), Text = "- Frog Speed 25 feet, swim Speed 25 feet; Melee [one-action] jaws, Damage 2d6 bludgeoning; Melee [one-action] tongue (reach 15 feet), Damage 2d4 bludgeoning." };
            yield return new SpellDetailBlock { Id = Guid.Parse("69870368-0e1e-43a6-9939-de554f70b183"), Text = "- Shark swim Speed 35 feet; Melee [one-action] jaws, Damage 2d8 piercing; breathe underwater but not in air." };
            yield return new SpellDetailBlock { Id = Guid.Parse("f388440c-c3bf-46ed-8048-109135a6e719"), Text = "- Snake Speed 20 feet, climb Speed 20 feet, swim Speed 20 feet; Melee[one - action] fangs, Damage 2d4 piercing plus 1d6 poison." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening { Id = Guid.Parse("63371eec-c1ea-4dcb-8c53-e72fe03224a8"), Level = 3, Description = "You instead gain 10 temporary HP, AC = 17 + your level, attack modifier +14, damage bonus +5, and Athletics +14." };
            yield return new SpellHeightening { Id = Guid.Parse("62d0851a-cc5e-462c-aee1-1b5e812ac054"), Level = 4, Description = "Your battle form is Large and your attacks have 10-foot reach. You must have enough space to expand into or the spell is lost. You instead gain 15 temporary HP, AC = 18 + your level, attack modifier +16, damage bonus +9, and Athletics +16." };
            yield return new SpellHeightening { Id = Guid.Parse("7bd4ff03-9047-4baa-939e-312c7924b42d"), Level = 5, Description = "Your battle form is Huge and your attacks have 15-foot reach. You must have enough space to expand into or the spell is lost. You instead gain 20 temporary HP, AC = 18 + your level, attack modifier +18, damage bonus +7 and double the number of damage dice, and Athletics +20." };
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
