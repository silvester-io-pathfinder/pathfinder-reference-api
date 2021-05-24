using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Staves.Instances
{
    public class StaffOfConjuration : Template
    {
        public static readonly Guid ID = Guid.Parse("0bda6552-d25a-4dc2-9b4b-8e26e2a34bdd");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of Conjuration",
                Usage = "Held in 1 hand",
                Activate = "Cast a Spell.",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("fbc2eace-cdf2-4435-8eee-9b5df9ef751f"), Type = TextBlockType.Text, Text = "This ash staff is decorated with animals; wielding it, you gain a +2 circumstance bonus to checks to identify conjuration magic." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("3db7421c-03f9-43be-90b1-0ccdd78e95eb"),
                Name = "Cast a Spell",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("f432af01-b4db-4e60-9656-a02f885ddd47"), Type = TextBlockType.Text, Text = "You expend a number of charges from the staff to cast a spell from its list." }
                }
            };
        }

        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("e5f4e586-e8d7-4666-ae9a-b77574163d41"),
                Price = 23000,
                ItemLevel = 6,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("1b2659d3-650e-43d0-bde6-a5c77f6c0b42"), SpellId = Spells.Instances.Tanglefoot.ID},
                    new StaveSpell { Id = Guid.Parse("6c5d1f31-7031-4cd2-aceb-f152f45ecda7"), Level = 1, SpellId = Spells.Instances.SummonConstruct.ID},
                    new StaveSpell { Id = Guid.Parse("38a34d82-d63b-44f6-9340-1d3059818cba"), Level = 1, SpellId = Spells.Instances.UnseenServant.ID},
                    new StaveSpell { Id = Guid.Parse("dae6772e-da92-4af2-816a-d7280f0257c2"), Level = 2, SpellId = Spells.Instances.ObscuringMist.ID},
                    new StaveSpell { Id = Guid.Parse("e2d91c83-99e7-4307-b1b4-99f1964e9f98"), Level = 2, SpellId = Spells.Instances.PhantomSteed.ID},
                    new StaveSpell { Id = Guid.Parse("492c9c38-fc0b-4b1a-b650-0e13bc055c0d"), Level = 2, SpellId = Spells.Instances.SummonConstruct.ID},
                    new StaveSpell { Id = Guid.Parse("578b7372-a511-49da-9889-c75220177e59"), Level = 2, SpellId = Spells.Instances.SummonElemental.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("e092a7eb-7a53-434f-91ea-e946bb6b2cc2"),
                Price = 90000,
                ItemLevel = 10,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("3e40a8a4-6355-4d97-be63-192e75eabe4d"), Level = 3, SpellId = Spells.Instances.StinkingCloud.ID},
                    new StaveSpell { Id = Guid.Parse("46dc9c73-356e-4eca-85b8-b9d3e8bd7884"), Level = 3, SpellId = Spells.Instances.SummonConstruct.ID},
                    new StaveSpell { Id = Guid.Parse("0105e674-d521-4b18-83f7-904be217b0ab"), Level = 3, SpellId = Spells.Instances.SummonElemental.ID},
                    new StaveSpell { Id = Guid.Parse("69db1b49-77e8-4006-b275-2da6d3c0c379"), Level = 4, SpellId = Spells.Instances.Creation.ID},
                    new StaveSpell { Id = Guid.Parse("71eb28c9-0d98-4aec-ab18-d62693ffbdee"), Level = 4, SpellId = Spells.Instances.PhantomSteed.ID},
                    new StaveSpell { Id = Guid.Parse("b5ab4f6a-c688-4b9d-8e2c-06fc5994fa58"), Level = 4, SpellId = Spells.Instances.SummonConstruct.ID},
                    new StaveSpell { Id = Guid.Parse("6e8d5860-74a7-4851-8f1c-e5fc04142fba"), Level = 4, SpellId = Spells.Instances.SummonElemental.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("014fb783-3187-4b05-b688-8e6850699197"),
                Price = 400000,
                ItemLevel = 14,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("f2dfdfaf-ec60-47d5-98f3-c7356ad1c609"), Level = 5, SpellId = Spells.Instances.BlackTentacles.ID},
                    new StaveSpell { Id = Guid.Parse("a7fdf95c-c555-4d0c-975e-30678e7d1882"), Level = 5, SpellId = Spells.Instances.SummonConstruct.ID},
                    new StaveSpell { Id = Guid.Parse("35385702-7fa8-4d86-bd6b-4160edc634be"), Level = 5, SpellId = Spells.Instances.SummonElemental.ID},
                    new StaveSpell { Id = Guid.Parse("392e6290-4a1c-49ea-8c93-ad90ca6f7e7f"), Level = 6, SpellId = Spells.Instances.PhantomSteed.ID},
                    new StaveSpell { Id = Guid.Parse("f3648514-9109-4c81-8b12-649b556f4228"), Level = 6, SpellId = Spells.Instances.SummonConstruct.ID},
                    new StaveSpell { Id = Guid.Parse("4e26a0c0-6ece-47bc-86a8-374ee8b0a581"), Level = 6, SpellId = Spells.Instances.SummonElemental.ID},
                }
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Staff.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("21886b3d-a4e8-4a79-8eec-169d60936079"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 594
            };
        }
    }
}
