using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Staves.Instances
{
    public class StaffOfHealing : Template
    {
        public static readonly Guid ID = Guid.Parse("7df574ec-0a8a-40f1-9ff0-d43b341ce224");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of Healing",
                Usage = "Held in 1 hand",
                Activate = "Cast a Spell.",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
            };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("08c2ff84-48e6-4416-9c94-ffb1ff51ccf0"),
                Name = "Cast a Spell",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("62ed3a95-d7ec-4149-a2e3-62e25eb9722e"), Type = TextBlockType.Text, Text = "You expend a number of charges from the staff to cast a spell from its list." }
                }
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f325d179-14a1-447d-b9ee-5e624663d58a"), Type = TextBlockType.Text, Text = "Made of smooth, white wood, this staff is capped at each end with a golden cross adorned with a multitude of ruby cabochons. A staff of healing grants an item bonus to the Hit Points you restore anytime you cast the heal spell using your own spell slots or using charges from the staff." };
        }

        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("1ac0e3dc-9dcc-4723-b954-4cfa99b3bbcd"),
                Price = 9000,
                ItemLevel = 4,
                Addendum = "The item bonus granted to heal spells is +1.",
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("13f37dc3-6fec-488c-af4c-1ed7d1360498"), SpellId = Spells.Instances.Stabilize.ID},
                    new StaveSpell { Id = Guid.Parse("131b0d8e-4d69-4de6-bab9-c3a8e9238e9a"), Level = 1, SpellId = Spells.Instances.Heal.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("332121c2-dcb3-4efa-8350-5e3eea755e1e"),
                Price = 47000,
                ItemLevel = 8,
                Addendum = "The item bonus granted to heal spells is +2.",
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("3559f8ed-e535-499b-ac57-9b1f47c4b273"), Level = 2, SpellId = Spells.Instances.Heal.ID},
                    new StaveSpell { Id = Guid.Parse("951caeaa-e0f2-4d0a-ab2f-f578f4eceee4"), Level = 2, SpellId = Spells.Instances.Restoration.ID},
                    new StaveSpell { Id = Guid.Parse("99816a5e-485d-44f4-ac77-7a22a9c5cb59"), Level = 2, SpellId = Spells.Instances.RestoreSenses.ID},
                    new StaveSpell { Id = Guid.Parse("4fe2862e-4e78-4924-ae25-c7b449b29601"), Level = 3, SpellId = Spells.Instances.Heal.ID},
                    new StaveSpell { Id = Guid.Parse("bf3d09b6-4349-43d2-89cd-640d9d9aff75"), Level = 3, SpellId = Spells.Instances.RemoveDisease.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("64bdd93e-bdf7-41ba-a4c1-ce3831baec7f"),
                Price = 180000,
                ItemLevel = 12,
                Addendum = "The item bonus granted to heal spells is +3.",
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("d21a467b-7cd0-46ca-a3ed-a5669216ed10"), Level = 4, SpellId = Spells.Instances.Heal.ID},
                    new StaveSpell { Id = Guid.Parse("11980430-90b0-4da5-9224-bd41828c3547"), Level = 4, SpellId = Spells.Instances.Restoration.ID},
                    new StaveSpell { Id = Guid.Parse("171fac58-c769-44c6-b088-9f55008f9b4f"), Level = 5, SpellId = Spells.Instances.BreathOfLife.ID},
                    new StaveSpell { Id = Guid.Parse("f02fa874-f53f-442b-8a3e-fde8d68e32d8"), Level = 5, SpellId = Spells.Instances.Heal.ID},
                    new StaveSpell { Id = Guid.Parse("e58ec502-8f99-45eb-858d-c4a8a831fc40"), Level = 5, SpellId = Spells.Instances.RemoveDisease.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("33bcd18f-66d4-4860-96b4-f8aec0bfb341"),
                Price = 920000,
                ItemLevel = 16,
                Addendum = "The item bonus granted to heal spells is +4.",
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.True.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("7fc174c2-9fb1-4465-bb03-b698470eee2a"), Level = 6, SpellId = Spells.Instances.Heal.ID},
                    new StaveSpell { Id = Guid.Parse("3af8fd04-ef66-4880-88de-05c66da6a9a2"), Level = 6, SpellId = Spells.Instances.Restoration.ID},
                    new StaveSpell { Id = Guid.Parse("26a1ad2b-2186-4d03-b6ee-5a7a762f5af4"), Level = 6, SpellId = Spells.Instances.RestoreSenses.ID},
                    new StaveSpell { Id = Guid.Parse("c8029e82-ebdd-41af-ade7-c7d1d14afca1"), Level = 7, SpellId = Spells.Instances.Heal.ID},
                    new StaveSpell { Id = Guid.Parse("2bd402ec-d656-4775-9ad4-7b4f27e119bd"), Level = 7, SpellId = Spells.Instances.Regenerate.ID},
                    new StaveSpell { Id = Guid.Parse("cff84142-9e9f-4701-9a87-b2d8ab44cfef"), Level = 7, SpellId = Spells.Instances.RemoveDisease.ID},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Staff.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ddaf3b83-2f7b-4757-b9f1-e29b91726dc3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 595
            };
        }
    }
}
