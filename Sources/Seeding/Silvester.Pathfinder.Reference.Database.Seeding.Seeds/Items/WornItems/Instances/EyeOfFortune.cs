using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemCategories.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WornItems.Instances
{
    public class EyeOfFortune : Template
    {
        public static readonly Guid ID = Guid.Parse("e145f9ea-6003-4e76-80e1-00589ae0bfde");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Eye of Fortune",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("b638d830-43ea-446d-8f51-7979db65e192"), "Adherents of Erastil, god of the hunt, create these magical eye patches. An eye of fortune has a jeweled eye symbol on its front, allowing you to magically see through the eye patch as though it were transparent.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("5147edc0-735a-4592-b951-f16b1a148732"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("53ce30a1-4700-4269-9ff2-2f54a56a2925"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("2d42b89a-0e48-4828-9e46-8436799ef923"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("221a10c3-c35b-4135-9380-19f6e0144f05"),
				Name = "Eye of Fortune",
                Usage = "Worn eyepiece.",
				Level = 13,
				Price = 270000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("166fdc98-c040-4267-afc0-41db2e7030f1"), ActionTypes.Instances.FreeAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Envision")
                            .Trigger("You attack a concealed or hidden creature and haven't attempted the flat check yet.")
                            .Traits(builder =>
                            {
                                builder.Add(Guid.Parse("e327e6dc-1fc1-4ef6-b12c-9d36292ce78c"), Traits.Instances.Fortune.ID);
                            })
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("ca730a55-2625-4135-a4d2-cb6ef26f95c5"), "You can roll the flat check for the concealed or hidden condition twice and use the higher result.");
                            });
                    })
                    .Build()
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f60aca07-3312-4558-8253-61fe7f8d6eb8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 610
            };
        }
    }
}
