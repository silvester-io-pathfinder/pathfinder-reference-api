using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Staves.Instances
{
    public class StaffOfDivination : Template
    {
        public static readonly Guid ID = Guid.Parse("c0d7e91e-f22f-45d6-b506-214bf7f32883");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of Divination",
                Usage = "Held in 1 hand",
                Activate = "Cast a Spell.",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("167e1f8a-97f1-4c3c-ad9d-4ca54924adc1"), Type = TextBlockType.Text, Text = "Semiprecious gemstones emerge, seemingly at random, from the surface of this gnarled wooden staff. While wielding it, you gain a +2 circumstance bonus to checks to identify divination magic." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("0a784ccf-3776-4713-8132-d9b54dbaed34"),
                Name = "Cast a Spell",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("f305a289-162d-4567-9729-1ac7a64f9a24"), Type = TextBlockType.Text, Text = "You expend a number of charges from the staff to cast a spell from its list." }
                }
            };
        }

        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("e36b91a7-0518-45a8-b0be-dfc2c04cf7ce"),
                Price = 23000,
                ItemLevel = 6,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("de8e4156-0d1d-4c8f-b555-c00646a5971f"), SpellId = Spells.Instances.DetectMagic.ID},
                    new StaveSpell { Id = Guid.Parse("518a4c4c-bed5-45dc-b27f-049f7d86dbf9"), Level = 1, SpellId = Spells.Instances.TrueStrike.ID},
                    new StaveSpell { Id = Guid.Parse("42c9d55b-0852-4f19-a737-d5e638709d2a"), Level = 2, SpellId = Spells.Instances.ComprehendLanguage.ID},
                    new StaveSpell { Id = Guid.Parse("268ff172-d0df-414f-92c2-7c77203e12a0"), Level = 2, SpellId = Spells.Instances.Darkvision.ID},
                    new StaveSpell { Id = Guid.Parse("3f73e9cc-bd49-47a1-b6ac-bbab38236217"), Level = 2, SpellId = Spells.Instances.SeeInvisibility.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("f0329a30-d0b7-440f-a491-933ef1124bfc"),
                Price = 90000,
                ItemLevel = 10,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("9de8c700-da38-4468-92ec-025dabe32c83"), Level = 3, SpellId = Spells.Instances.Clairaudience.ID},
                    new StaveSpell { Id = Guid.Parse("b482daed-ce90-4d38-a78a-12b0c0980c03"), Level = 3, SpellId = Spells.Instances.Darkvision.ID},
                    new StaveSpell { Id = Guid.Parse("3e0ecc0b-0d4f-42db-831f-f6fd1d1ee67a"), Level = 4, SpellId = Spells.Instances.Clairvoyance.ID},
                    new StaveSpell { Id = Guid.Parse("7a7569eb-7df9-4f30-be4d-064a3d1f9d72"), Level = 4, SpellId = Spells.Instances.ComprehendLanguage.ID},
                    new StaveSpell { Id = Guid.Parse("74889b33-9658-4fde-8c28-34bfa7cc2662"), Level = 4, SpellId = Spells.Instances.Telepathy.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("31a7723f-78a8-4f7f-999a-b3a240be2161"),
                Price = 400000,
                ItemLevel = 14,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("78c923eb-c8e7-42e0-8037-f45560a6ce2d"), Level = 5, SpellId = Spells.Instances.PryingEye.ID},
                    new StaveSpell { Id = Guid.Parse("63c47cc6-eb08-41a7-95ce-f9bf3921a65f"), Level = 5, SpellId = Spells.Instances.Sending.ID},
                    new StaveSpell { Id = Guid.Parse("6c64aaaf-2d04-4bfd-9074-7243559ad07c"), Level = 6, SpellId = Spells.Instances.Telepathy.ID},
                    new StaveSpell { Id = Guid.Parse("91c37ac3-1a86-4fca-9fb7-25ce39a740c4"), Level = 6, SpellId = Spells.Instances.TrueSeeing.ID},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Staff.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("41481c97-3ccf-4a35-82a8-ca4d25291d55"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 594
            };
        }
    }
}
