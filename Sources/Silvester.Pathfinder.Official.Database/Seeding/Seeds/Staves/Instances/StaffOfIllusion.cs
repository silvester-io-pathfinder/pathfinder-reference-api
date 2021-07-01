using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Staves.Instances
{
    public class StaffOfIllusion : Template
    {
        public static readonly Guid ID = Guid.Parse("7e5e3c63-4054-46a2-a209-2262f07d2e5e");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of Illusion",
                Usage = "Held in 1 hand",
                Activate = "Cast a Spell.",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8a7b6786-fe4c-4bf8-9daf-8204f786b689"), Type = TextBlockType.Text, Text = "This ornately designed metal staff shines with precious inlays of gold. When you Cast a Spell from the staff, the illusory image of something you desire flashes across its surface. While wielding the staff, you gain a +2 circumstance bonus to checks to identify illusion magic." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("0442bf20-b4d3-4064-a40d-d367e6af833d"),
                Name = "Cast a Spell",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("5bcaed32-1f6a-47c0-a1f8-a31af15d97af"), Type = TextBlockType.Text, Text = "You expend a number of charges from the staff to cast a spell from its list." }
                }
            };
        }

        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("81c8a778-701c-426c-8294-b2d00912e1a4"),
                Price = 23000,
                ItemLevel = 6,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("b75404d6-8a78-4d77-bb5d-3cb6d0e849d1"), SpellId = Spells.Instances.GhostSound.ID},
                    new StaveSpell { Id = Guid.Parse("15b6ec90-4874-4b8f-afb3-dce051e94fe6"), Level = 1, SpellId = Spells.Instances.IllusoryDisguise.ID},
                    new StaveSpell { Id = Guid.Parse("acc3a3bc-ec4a-415e-b5a3-d5b4a659d799"), Level = 1, SpellId = Spells.Instances.IllusoryObject.ID},
                    new StaveSpell { Id = Guid.Parse("2a6f2ee4-5d9c-4e1f-aa94-cfcecf1529fa"), Level = 2, SpellId = Spells.Instances.IllusoryCreature.ID},
                    new StaveSpell { Id = Guid.Parse("884264f2-b35a-4162-94f4-a6b8bc656647"), Level = 2, SpellId = Spells.Instances.ItemFacade.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("931f2052-45d0-4602-a94a-fc3ad183a9e7"),
                Price = 90000,
                ItemLevel = 10,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("9f9483c8-c835-479f-b8cd-ee258bf4ae05"), Level = 3, SpellId = Spells.Instances.IllusoryDisguise.ID},
                    new StaveSpell { Id = Guid.Parse("be05fd63-f187-4b61-a8b7-890b34600fc7"), Level = 3, SpellId = Spells.Instances.ItemFacade.ID},
                    new StaveSpell { Id = Guid.Parse("087f4701-541a-4711-ae70-ed7a0c6570c9"), Level = 4, SpellId = Spells.Instances.IllusoryCreature.ID},
                    new StaveSpell { Id = Guid.Parse("1ef0a839-2e1a-49d3-9bcd-10247cde68b2"), Level = 4, SpellId = Spells.Instances.Veil.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("d1bb9ebd-8726-4a30-8320-4d2de314fce8"),
                Price = 400000,
                ItemLevel = 14,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("7f2dee83-c094-4642-ab4b-133af53075eb"), Level = 5, SpellId = Spells.Instances.IllusoryScene.ID},
                    new StaveSpell { Id = Guid.Parse("dcb814af-5cc7-46d5-b523-3408bb90edc4"), Level = 5, SpellId = Spells.Instances.Veil.ID},
                    new StaveSpell { Id = Guid.Parse("0ce92b64-e408-44f3-a807-53b56c10f838"), Level = 6, SpellId = Spells.Instances.Hallucination.ID},
                    new StaveSpell { Id = Guid.Parse("ac2e02dd-e065-4a1b-a62a-513f24fc812d"), Level = 6, SpellId = Spells.Instances.Mislead.ID},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Staff.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8d862f50-b99f-4b01-b675-c06795027284"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 595
            };
        }
    }
}
