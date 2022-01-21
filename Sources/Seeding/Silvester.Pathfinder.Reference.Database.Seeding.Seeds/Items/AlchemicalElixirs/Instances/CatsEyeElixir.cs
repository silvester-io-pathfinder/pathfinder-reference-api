using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AlchemicalElixirs.Instances
{
    public class CatsEyeElixir : Template
    {
        public static readonly Guid ID = Guid.Parse("9273e6ad-3f3c-4e7d-9b9c-4a8faec61145");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                Name = "Cat's Eye Elixir",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("70db1dfe-abca-4416-b8ba-8825604c77d9"), "After you consume this elixir, your vision sharpens and you become sensitive to even the most minute movements. For the next minute, you reduce the flat check to target hidden creatures to 5, and you don't need to attempt a flat check to target concealed creatures. These benefits apply only against creatures within 30 feet of you."); ;
        }

        protected override IEnumerable<AlchemicalElixirVariant> GetAlchemicalElixirVariants()
        {
            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("39b6c273-ce0b-46a5-ab96-6603a5d79ed4"),
                Name = "Cat's Eye Elixir",
                Usage = "Held in 1 hand",
                Level = 1,
				Price = 700,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Standard.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("f48f1a70-604b-475d-af5f-d224e55a6c5a"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("93a3b0ab-004d-45f5-8668-283f4d710294"), "The Cat's Eye Elixir only exists in a single form, so no other potencies exist.")
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("d0f7b5b1-3947-430f-999c-ea655af7b1f6"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("b3b45087-6060-4f41-8321-7b71407f5a12"), Traits.Instances.Elixir.ID);
            builder.Add(Guid.Parse("4e925cc9-7592-4d98-8a1d-358f840c5eb7"), Traits.Instances.Consumable.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6773943d-c2fc-4e8a-ba93-e1d4d9766757"),
                SourceId = CoreRulebook.ID,
                Page = 547
            };
        }
    }
}
