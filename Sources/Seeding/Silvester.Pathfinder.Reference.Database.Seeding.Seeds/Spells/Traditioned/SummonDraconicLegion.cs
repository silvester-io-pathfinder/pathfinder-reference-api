using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
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
        }

        protected override IEnumerable<InlineAction> GetInlineActions()
        {
            yield return new InlineAction
            {
                Id = Guid.Parse("dc76e04d-d8ad-4140-b1b1-312c0aa3e6d0"),
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                Name = "Arrive",
                Traits = new[]
                {
                    new InlineActionTraitBinding { Id = Guid.Parse("1469fd93-b157-4b1f-bbd5-9e57f22fe905"), TraitId = Traits.Instances.Evocation.ID },
                },
                Effect = new[]
                {
                    new TextBlock { Id = Guid.Parse("4fc65f46-f697-4024-a926-f1ee8758f11b"), Type = TextBlockType.Heading, Text = "Energy Annihilation" },
                    new TextBlock { Id = Guid.Parse("cafe6b61-80ef-4f26-98a0-6df7adf1c7fb"), Type = TextBlockType.Text, Text = "The draconic legion breathes out two blasts of energy: a 120-foot line and a 60-foot cone that can�t overlap. Each creature in either of the areas takes 10d8 damage (basic Reflex save). The dragons choose the damage type of each breath weapon, depending on the category of dragons summoned. Chromatic dragons can choose cold, fire, or poison for the cone and acid or electricity for the line; metallic dragons can choose cold or fire for the cone and acid, electricity, or fire for the line." },
                }
            };

            yield return new InlineAction
            {
                Id = Guid.Parse("c0de8cee-1ac5-45b8-9e23-b48493b4260b"),
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                Name = "Depart",
                Effect = new[]
                {
                    new TextBlock { Id = Guid.Parse("2cb3599d-b9e9-47d5-a8a7-d42c9e9f62c4"), Type = TextBlockType.Heading, Text = "Draconic Whirlwind" },
                    new TextBlock { Id = Guid.Parse("770a186b-901d-4616-b63d-cf7dd1274d42"), Type = TextBlockType.Text, Text = "The draconic legion strikes with fury, dealing 9d8 slashing damage (basic Reflex save) to all enemy creatures in its location or within 20 feet." },
                }
            };
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("ed57599a-5254-4439-9c80-9eb17c3e9a57"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("5ceafcf9-5b3c-4696-885f-ccc10e909d97"), Traits.Instances.Incarnate.ID);
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
