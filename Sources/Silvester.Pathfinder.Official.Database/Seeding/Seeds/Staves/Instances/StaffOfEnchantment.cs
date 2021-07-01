using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Staves.Instances
{
    public class StaffOfEnchantment : Template
    {
        public static readonly Guid ID = Guid.Parse("aa970d4a-5183-439c-bbf0-fbebd9bfa612");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of Enchantment",
                Usage = "Held in 1 hand",
                Activate = "Cast a Spell.",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("bb2b3277-0920-4742-99e2-4bcd11ba51fa"), Type = TextBlockType.Text, Text = "A mesmerizing gemstone caps the head of this handsomely crafted wooden staff. While wielding the staff, you gain a +2 circumstance bonus to checks to identify enchantment magic." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("b0c729c1-3ce6-4a7f-bf1c-aedea7ccebe7"),
                Name = "Cast a Spell",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("c96b724f-c2b1-45b5-be3b-274c711ae201"), Type = TextBlockType.Text, Text = "You expend a number of charges from the staff to cast a spell from its list." }
                }
            };
        }

        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("5dba5151-aabb-4bfa-a823-71546ff3f2ed"),
                Price = 23000,
                ItemLevel = 6,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("c740691f-9c50-49e3-9848-d9d08a4bd108"), SpellId = Spells.Instances.Daze.ID},
                    new StaveSpell { Id = Guid.Parse("c833c8cb-97b9-47e8-89a7-48f59ecf8468"), Level = 1, SpellId = Spells.Instances.Charm.ID},
                    new StaveSpell { Id = Guid.Parse("eb1f9031-01f0-47cb-b803-c073584d86e7"), Level = 1, SpellId = Spells.Instances.Command.ID},
                    new StaveSpell { Id = Guid.Parse("0aa57aa6-f213-47e1-a357-14bb6bb36758"), Level = 2, SpellId = Spells.Instances.HideousLaughter.ID},
                    new StaveSpell { Id = Guid.Parse("8a24577e-6ff9-4a7c-a538-33b785c3401b"), Level = 2, SpellId = Spells.Instances.TouchOfIdiocy.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("f30e27f6-c009-47f4-b777-31aa55376a7f"),
                Price = 90000,
                ItemLevel = 10,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("16b10aaf-d013-4f73-958f-f5834aaa5cb1"), Level = 3, SpellId = Spells.Instances.Paralyze.ID},
                    new StaveSpell { Id = Guid.Parse("809940c8-978f-4816-b630-7489eca9a5cf"), Level = 4, SpellId = Spells.Instances.Charm.ID},
                    new StaveSpell { Id = Guid.Parse("a3a034bb-1abb-449e-bf1f-2b66d7fb2935"), Level = 4, SpellId = Spells.Instances.Confusion.ID},
                    new StaveSpell { Id = Guid.Parse("de53a226-3b4d-4c7e-ab63-581a5ccd46cf"), Level = 4, SpellId = Spells.Instances.Suggestion.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("d4fbabbb-f99b-45af-a164-2ebfdbd845e3"),
                Price = 400000,
                ItemLevel = 14,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("e9caf0c4-6dd7-4d81-9a79-5934612c7d12"), Level = 5, SpellId = Spells.Instances.Command.ID},
                    new StaveSpell { Id = Guid.Parse("18ba7469-7eed-41a9-b680-4619479446ee"), Level = 5, SpellId = Spells.Instances.CrushingDespair.ID},
                    new StaveSpell { Id = Guid.Parse("c70147b4-1607-4278-8db7-ebb2aa5d094a"), Level = 6, SpellId = Spells.Instances.Dominate.ID},
                    new StaveSpell { Id = Guid.Parse("4d7edaca-a6a9-4642-ab4b-835404a5c703"), Level = 6, SpellId = Spells.Instances.Feeblemind.ID},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Staff.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e3efcc10-d2e2-4857-ac80-0730b3cb1023"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 594
            };
        }
    }
}
