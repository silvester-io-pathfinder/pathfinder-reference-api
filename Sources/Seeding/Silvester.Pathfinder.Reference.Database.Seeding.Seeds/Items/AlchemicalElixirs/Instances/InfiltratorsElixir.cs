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
    public class InfiltratorsElixir : Template
    {
        public static readonly Guid ID = Guid.Parse("f8b7608f-3330-494d-8203-64cb7aeaa477");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                Name = "Infiltrator's Elixir",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("5c24f746-2f04-48a2-9b74-ab5c70e42203"), "Favored by spies and tricksters, an infiltrator's elixir is used to alter your appearance. When imbibed, you take the shape of a humanoid creature of your size, but different enough so you might be unrecognizable. If you aren't a humanoid, you might take on a form more similar to your own, at the GM's discretion."); ;
            builder.Text(Guid.Parse("1e77fd3e-28cf-47ca-a2e5-085bf9673e30"), "The creator of the elixir decides the basics of the appearance you transform into when you imbibe the elixir, including eye color, skin tone, and hair color. The elixir can't change your form into that of a specific person. After the form takes hold, you retain it for the next 10 minutes."); ;
            builder.Text(Guid.Parse("7ea16d23-375f-4b4e-8400-35d31a29f574"), "Drinking this elixir counts as setting up a disguise to Impersonate. You gain a +4 status bonus to your Deception DC to avoid others seeing through your disguise, and you add your level to this DC even if untrained."); ;
        }

        protected override IEnumerable<AlchemicalElixirVariant> GetAlchemicalElixirVariants()
        {
            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("747d368f-bf50-4339-91f8-453352f91260"),
                Name = "Infiltrator's Elixir",
                Usage = "Held in 1 hand",
                Level = 2,
				Price = 6,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Standard.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("e0208ab5-d9bb-4caf-a7f2-2f11a1b08fa3"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("d324f727-c1e1-4561-a041-e3b0c395d2fe"), "The Infiltrator's Elixir only exists as a single unclassified potency.")
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("416eb06a-a298-4675-8249-b56e8e7ad71b"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("34460a35-28c0-4b79-a486-55b6b435d427"), Traits.Instances.Elixir.ID);
            builder.Add(Guid.Parse("e8de010f-5f5d-437e-a1c8-a44ffc0965b2"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("48fbafea-0793-4cab-b188-5a64ae5076c1"), Traits.Instances.Polymorph.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("57e30628-306c-423f-9d3c-5a6aa4904952"),
                SourceId = CoreRulebook.ID,
                Page = 548
            };
        }
    }
}
