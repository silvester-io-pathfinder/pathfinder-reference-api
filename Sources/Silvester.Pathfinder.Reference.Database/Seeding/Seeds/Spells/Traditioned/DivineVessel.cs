using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DivineVessel : Template
    {
        public static readonly Guid ID = Guid.Parse("6e689573-2fdb-409f-abd2-a27135775498");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Divine Vessel",
                Level = 7,
                Duration = "1 minute",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("79f7c04c-7f10-4574-ae4c-5ea1c9921ef0"), Type = Utilities.Text.TextBlockType.Text, Text = "You accept otherworldly energies into your body; while you are still recognizably yourself, you gain the features of one of your deity’s servitors. Choose an alignment your deity has (chaotic, evil, good, or lawful). You can’t cast this spell if you don’t have a deity or your deity is true neutral. This spell gains the trait of the alignment you chose." };
            yield return new TextBlock { Id = Guid.Parse("32014b54-ab8b-4c60-be4e-2ab72ae18ea0"), Type = Utilities.Text.TextBlockType.Text, Text = "If you were Medium or smaller, you become Large, as the effects of enlarge. You must have space to expand into, or the spell is lost. You also gain the following benefits." };
            yield return new TextBlock { Id = Guid.Parse("e38e0b0c-dd32-4e48-8f7c-b5dd74371b98"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "40 temporary Hit Points." };
            yield return new TextBlock { Id = Guid.Parse("efab6a65-c298-4b9e-a580-9ff3726bb950"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "A fly Speed equal to your Speed." };
            yield return new TextBlock { Id = Guid.Parse("e25b180f-db39-4c21-9ed3-6d808c006020"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Weakness 10 to the alignment opposite the one you chose." };
            yield return new TextBlock { Id = Guid.Parse("08a3e3f0-9d91-4c27-87b8-df3ff705ca2d"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "A +1 status bonus to saves against spells." };
            yield return new TextBlock { Id = Guid.Parse("c16c0f4b-da16-4d0f-9cb2-baab4ba1667c"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Darkvision." };
            yield return new TextBlock { Id = Guid.Parse("e13e5c33-fa04-43d2-9430-8ee5988e2e62"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Your unarmed attacks and weapons deal 1 additional damage of the chosen alignment type." };
            yield return new TextBlock { Id = Guid.Parse("37ac6077-a033-413b-b8f6-1120ec70cb14"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "One or more unarmed melee attacks. If you chose good or lawful, your fist attacks deal 2d8 damage. If you chose chaotic, you gain a bite unarmed attack that deals 2d10 piercing damage. If you chose evil, you gain a claws unarmed attack that deals 2d8 slashing damage and has the agile and finesse traits." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("842ac0e3-6867-4a83-b8fa-8e60db388251"), 
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("8683a40b-d930-463a-8063-c4e07c76b89e"), Type = Utilities.Text.TextBlockType.Text, Text = "The temporary Hit Points increase to 60, the weakness increases to 15, and the duration increases to 10 minutes." }
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Morph.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c087cd1c-7a7c-495b-8cde-23804404d8f3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 331
            };
        }
    }
}
