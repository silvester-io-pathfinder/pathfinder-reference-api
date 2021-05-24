using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Staves.Instances
{
    public class AnimalStaff : Template
    {
        public static readonly Guid ID = Guid.Parse("c6e92b4d-5564-4bf9-8cf8-e3d254c06786");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Animal Staff",
                Usage = "Held in 1 hand",
                Activate = "Cast a Spell.",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8179200f-aa5a-40f0-b249-ddf1fdb170b5"), Type = TextBlockType.Text, Text = "This staff is topped with carved animal and monster heads. While wielding the staff, you gain a +2 circumstance bonus to Nature checks to identify animals." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("d7cdf6ec-15f5-4f8a-b545-6bcd3e380e6a"),
                Name = "Cast a Spell",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("4ed63ce0-1db3-4f4d-b827-11a33a2517c9"), Type = TextBlockType.Text, Text = "You expend a number of charges from the staff to cast a spell from its list." }
                }
            };
        }

        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("3b6cc049-e262-4866-be8c-0cc42c807bb0"),
                Price = 9000,
                ItemLevel = 4,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("b4ad8c66-fe10-4fca-8829-bd02149c8e91"), SpellId = Spells.Instances.KnowDirection.ID},
                    new StaveSpell { Id = Guid.Parse("30e5f473-2d4f-4730-b3ce-d62de389de6c"), Level = 1, SpellId = Spells.Instances.MagicFang.ID},
                    new StaveSpell { Id = Guid.Parse("f9710185-0aab-4c23-9654-d735b0f72261"), Level = 1, SpellId = Spells.Instances.SummonAnimal.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("cfcbe18d-96aa-4216-8ee7-b0cab4276945"),
                Price = 46000,
                ItemLevel = 8,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("d4446c5d-3fcb-44be-ba85-e71857d4a34a"), Level = 2, SpellId = Spells.Instances.AnimalMessenger.ID},
                    new StaveSpell { Id = Guid.Parse("e1d6704a-fb64-4f04-9c80-9681ce0bd7b6"), Level = 2, SpellId = Spells.Instances.SpeakWithAnimals.ID},
                    new StaveSpell { Id = Guid.Parse("51f60983-5a9c-4409-be13-cd7ee4aca94b"), Level = 2, SpellId = Spells.Instances.SummonAnimal.ID},
                    new StaveSpell { Id = Guid.Parse("787bf10f-f2aa-43d5-a02f-bc8f942cad04"), Level = 3, SpellId = Spells.Instances.AnimalForm.ID},
                    new StaveSpell { Id = Guid.Parse("c4ddd80a-15e9-410b-bfa6-27e8c85cd3a1"), Level = 3, SpellId = Spells.Instances.SummonAnimal.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("529e9dd1-7862-4102-8942-146c19fca8fe"),
                Price = 190000,
                ItemLevel = 12,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("5716d17f-d96c-4b4b-b3b6-518976ab3971"), Level = 4, SpellId = Spells.Instances.SummonAnimal.ID},
                    new StaveSpell { Id = Guid.Parse("036a7176-fd05-4745-ba13-34aa13503525"), Level = 5, SpellId = Spells.Instances.AnimalForm.ID},
                    new StaveSpell { Id = Guid.Parse("003e55a2-806e-4c9e-bd97-732e3386aec7"), Level = 5, SpellId = Spells.Instances.MoonFrenzy.ID},
                    new StaveSpell { Id = Guid.Parse("ba7b528e-0195-4b30-99b5-bae99892b362"), Level = 5, SpellId = Spells.Instances.SummonAnimal.ID},
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
                Id = Guid.Parse("143f042c-1425-4d70-aaa4-6205785d462a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 593
            };
        }
    }
}
