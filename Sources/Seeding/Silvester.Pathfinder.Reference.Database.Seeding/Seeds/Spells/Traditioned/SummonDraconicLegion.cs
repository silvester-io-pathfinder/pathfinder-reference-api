using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SummonDraconicLegion : Template
    {
        public static readonly Guid ID = Guid.Parse("e32c2b70-792e-43cb-ac4d-459c3f921ad5");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Summon Draconic Legion",
                Level = 9,
                Range = "100 feet.",
                Duration = "Until the end of your next turn.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f6794f97-3568-4b8d-8918-5ec8344b0011"), Type = TextBlockType.Text, Text = "You momentarily summon an army of powerful dragons that unleash annihilating blasts as they descend upon your location. These dragons act as one and collectively occupy the space of a Gargantuan creature. They have a fly Speed of 100 feet. When you Cast this Spell, choose whether it summons chromatic or metallic dragons." };
            yield return new TextBlock { Id = Guid.Parse("80787c59-3db0-41bb-9c82-f9aee976b401"), Type = TextBlockType.Enumeration, Text = "Arrive: (evocation) Energy Annihilation The draconic legion breathes out two blasts of energy: a 120-foot line and a 60-foot cone that can�t overlap. Each creature in either of the areas takes 10d8 damage (basic Reflex save). The dragons choose the damage type of each breath weapon, depending on the category of dragons summoned. Chromatic dragons can choose cold, fire, or poison for the cone and acid or electricity for the line; metallic dragons can choose cold or fire for the cone and acid, electricity, or fire for the line." };
            yield return new TextBlock { Id = Guid.Parse("e1a0e33a-22fd-4d97-b375-89b97d27f46e"), Type = TextBlockType.Enumeration, Text = "Depart: Draconic Whirlwind The draconic legion strikes with fury, dealing 9d8 slashing damage (basic Reflex save) to all enemy creatures in its location or within 20 feet." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Incarnate.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("14273e57-2230-4a7a-95a5-87117327bcf6"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 133
            };
        }
    }
}
