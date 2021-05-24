using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Staves.Instances
{
    public class StaffOfAbjuration : Template
    {
        public static readonly Guid ID = Guid.Parse("efd9ac9d-3ca5-4736-9fe4-76b99043f84e");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of Abjuration",
                Usage = "Held in 1 hand",
                Activate = "Cast a Spell.",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("6c20923d-9951-45dc-8b8c-ec751501bce2"), Type = TextBlockType.Text, Text = "This intricately carved wooden staff is warm to the touch and thrums with inner energy. While wielding the staff, you gain a +2 circumstance bonus to checks to identify abjuration magic." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("865e5630-b5d0-46ee-90c1-841ad8c28457"),
                Name = "Cast a Spell",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("41907527-cd39-420d-b522-2015079bcb2a"), Type = TextBlockType.Text, Text = "You expend a number of charges from the staff to cast a spell from its list." }
                }
            };
        }

        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("474245c7-aa9d-4a00-8288-c4551de42bf6"),
                Price = 23000,
                ItemLevel = 6,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("f1f8b38a-b7f4-48d5-a7ca-19c385760378"), SpellId = Spells.Instances.Shield.ID},
                    new StaveSpell { Id = Guid.Parse("e2a35685-f198-41dc-93f1-b42c1d330c1f"), Level = 1, SpellId = Spells.Instances.Alarm.ID},
                    new StaveSpell { Id = Guid.Parse("a3f7badb-84a1-48d7-b4f0-0ee6964dcee6"), Level = 1, SpellId = Spells.Instances.FeatherFall.ID},
                    new StaveSpell { Id = Guid.Parse("36f666d2-3358-4269-8ef4-36b59b55b638"), Level = 2, SpellId = Spells.Instances.DispelMagic.ID},
                    new StaveSpell { Id = Guid.Parse("2bd7ceec-6e5d-4bf6-878d-dc39e3b71a6e"), Level = 2, SpellId = Spells.Instances.EndureElements.ID},
                    new StaveSpell { Id = Guid.Parse("a047f6b9-c555-45db-9cfe-30212ffef2e8"), Level = 2, SpellId = Spells.Instances.ResistEnergy.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("fb83be65-77f9-4948-898c-f7a2c28df5f7"),
                Price = 90000,
                ItemLevel = 10,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("3c826a5f-7007-4166-81cf-63207b889da3"), Level = 3, SpellId = Spells.Instances.Alarm.ID},
                    new StaveSpell { Id = Guid.Parse("296b59b6-b945-4539-a401-58fe5b61001f"), Level = 3, SpellId = Spells.Instances.GlyphOfWarding.ID},
                    new StaveSpell { Id = Guid.Parse("dbebeb72-bdb1-4291-b7bc-0a862fc5accf"), Level = 4, SpellId = Spells.Instances.DimensionalAnchor.ID},
                    new StaveSpell { Id = Guid.Parse("c47c29fa-2838-4201-9791-444cf06f48f8"), Level = 4, SpellId = Spells.Instances.DispelMagic.ID},
                    new StaveSpell { Id = Guid.Parse("4d43f417-9048-417b-abe2-f44bea4096aa"), Level = 4, SpellId = Spells.Instances.ResistEnergy.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("a9c80895-a250-4b85-8548-a133dcc16cb8"),
                Price = 400000,
                ItemLevel = 14,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("f7f4e7cc-5c68-4ad9-ade9-2963063f75c3"), Level = 5, SpellId = Spells.Instances.Banishment.ID},
                    new StaveSpell { Id = Guid.Parse("e17b8ff4-23b4-4023-9180-e3f9f7b6e712"), Level = 5, SpellId = Spells.Instances.EndureElements.ID},
                    new StaveSpell { Id = Guid.Parse("a83821e1-e72f-4669-af22-e5e778c6754c"), Level = 6, SpellId = Spells.Instances.DispelMagic.ID},
                    new StaveSpell { Id = Guid.Parse("a9935bcf-d042-4abe-9fc5-90e0946d17df"), Level = 6, SpellId = Spells.Instances.Repulsion.ID},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Staff.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("41dd9c83-e1d1-4d19-9ce5-375d462f5871"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 594
            };
        }
    }
}
