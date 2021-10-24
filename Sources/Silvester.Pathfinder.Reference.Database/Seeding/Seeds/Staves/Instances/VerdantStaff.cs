using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Staves.Instances
{
    public class VerdantStaff : Template
    {
        public static readonly Guid ID = Guid.Parse("a00e7823-576a-4c7e-91cc-7f3dc7b288e6");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Verdant Staff",
                Usage = "Held in 1 hand",
                Activate = "Cast a Spell.",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("74c3b504-4c48-47f3-b392-50b7a6ee42e9"), Type = TextBlockType.Text, Text = "This oak branch grows leaves in spring that change color in autumn and shed in winter. While wielding it, you gain a +2 circumstance bonus to Nature checks to identify plants." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("d3cc5d05-cecf-4892-88ce-7996b01093e6"),
                Name = "Cast a Spell",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("34d44bb3-61a3-47f1-9287-4b020d7d4b03"), Type = TextBlockType.Text, Text = "You expend a number of charges from the staff to cast a spell from its list." }
                }
            };
        }

        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("26164336-dc50-484b-ad35-5d30e7f5ee83"),
                Price = 22500,
                ItemLevel = 6,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("09efdca3-b5bb-453f-bd37-92c87064cca4"), SpellId = Spells.Instances.Tanglefoot.ID},
                    new StaveSpell { Id = Guid.Parse("2865df40-7196-4463-8de8-dcc49fbf240f"), Level = 1, SpellId = Spells.Instances.Shillelagh.ID},
                    new StaveSpell { Id = Guid.Parse("3e6196fc-74e6-4561-acf9-86e4084582fc"), Level = 2, SpellId = Spells.Instances.Barkskin.ID},
                    new StaveSpell { Id = Guid.Parse("563c6473-06b9-4edc-b981-2e779d1f19c2"), Level = 2, SpellId = Spells.Instances.Entangle.ID},
                    new StaveSpell { Id = Guid.Parse("5c030b98-5e06-4229-ab4d-64c41bfde474"), Level = 2, SpellId = Spells.Instances.ShapeWood.ID},
                    new StaveSpell { Id = Guid.Parse("82a84714-c217-49e1-bc23-f66e01db9970"), Level = 2, SpellId = Spells.Instances.TreeShape.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("2a2c4b14-3838-4b3b-a32d-f978eb055f56"),
                Price = 175000,
                ItemLevel = 12,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("a11141a1-0587-41ff-95b7-fd2893740326"), Level = 3, SpellId = Spells.Instances.WallOfThorns.ID},
                    new StaveSpell { Id = Guid.Parse("f56cd5ac-ed58-4d6d-bf85-53b51fc31f5e"), Level = 4, SpellId = Spells.Instances.Barkskin.ID},
                    new StaveSpell { Id = Guid.Parse("5bbc0c6a-0441-4f3a-94b1-7776330a9b75"), Level = 4, SpellId = Spells.Instances.SpeakWithPlants.ID},
                    new StaveSpell { Id = Guid.Parse("773416d7-8b4d-4e67-b46c-85768948f236"), Level = 5, SpellId = Spells.Instances.PlantForm.ID},
                    new StaveSpell { Id = Guid.Parse("dde7f63e-c6e9-4032-859c-d0a49743f2f4"), Level = 5, SpellId = Spells.Instances.WallOfThorns.ID},
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
                Id = Guid.Parse("af4fdec4-a45b-4077-8c21-ecb8cae3f4c7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 595
            };
        }
    }
}
