using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DivineVesselSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Transmutation";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("6e689573-2fdb-409f-abd2-a27135775498"),
                Name = "Divine Vessel",
                Description = "You accept otherworldly energies into your body; while you are still recognizably yourself, you gain the features of one of your deity’s servitors. Choose an alignment your deity has (chaotic, evil, good, or lawful). You can’t cast this spell if you don’t have a deity or your deity is true neutral. This spell gains the trait of the alignment you chose.",
                Level = 7,
                Duration = "1 minute"
            };
        }

        public override IEnumerable<SpellDetailBlock> GetSpellDetailBlocks()
        {
            yield return new SpellDetailBlock { Id = Guid.Parse("32014b54-ab8b-4c60-be4e-2ab72ae18ea0"), Text = "If you were Medium or smaller, you become Large, as the effects of enlarge. You must have space to expand into, or the spell is lost. You also gain the following benefits." };
            yield return new SpellDetailBlock { Id = Guid.Parse("e38e0b0c-dd32-4e48-8f7c-b5dd74371b98"), Text = "- 40 temporary Hit Points." };
            yield return new SpellDetailBlock { Id = Guid.Parse("efab6a65-c298-4b9e-a580-9ff3726bb950"), Text = "- A fly Speed equal to your Speed." };
            yield return new SpellDetailBlock { Id = Guid.Parse("e25b180f-db39-4c21-9ed3-6d808c006020"), Text = "- Weakness 10 to the alignment opposite the one you chose." };
            yield return new SpellDetailBlock { Id = Guid.Parse("08a3e3f0-9d91-4c27-87b8-df3ff705ca2d"), Text = "- A +1 status bonus to saves against spells." };
            yield return new SpellDetailBlock { Id = Guid.Parse("c16c0f4b-da16-4d0f-9cb2-baab4ba1667c"), Text = "- Darkvision." };
            yield return new SpellDetailBlock { Id = Guid.Parse("e13e5c33-fa04-43d2-9430-8ee5988e2e62"), Text = "- Your unarmed attacks and weapons deal 1 additional damage of the chosen alignment type." };
            yield return new SpellDetailBlock { Id = Guid.Parse("37ac6077-a033-413b-b8f6-1120ec70cb14"), Text = "- One or more unarmed melee attacks. If you chose good or lawful, your fist attacks deal 2d8 damage. If you chose chaotic, you gain a bite unarmed attack that deals 2d10 piercing damage. If you chose evil, you gain a claws unarmed attack that deals 2d8 slashing damage and has the agile and finesse traits." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening { Id = Guid.Parse("842ac0e3-6867-4a83-b8fa-8e60db388251"), Level = 9, Description = "The temporary Hit Points increase to 60, the weakness increases to 15, and the duration increases to 10 minutes." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Divine";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Morph";
            yield return "Transmutation";
        }
    }
}
