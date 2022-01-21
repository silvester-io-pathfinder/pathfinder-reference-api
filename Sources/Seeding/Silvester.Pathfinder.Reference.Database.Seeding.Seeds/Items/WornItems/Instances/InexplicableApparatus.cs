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
    public class InexplicableApparatus : Template
    {
        public static readonly Guid ID = Guid.Parse("5b1ff713-bbcc-42fb-9b60-6401bf6fcbf8");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Inexplicable Apparatus",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("ecc1ab23-9c63-41d7-9c0f-c823553e396e"), "This strange and intricate harness fits snugly to the torso. Once you invest the apparatus, numerous artificial limbs with various tools, clamps, and lenses whirl into action, following your mental commands effortlessly.");
            builder.Text(Guid.Parse("8df7225b-8901-4e94-abb7-6124d484c1e7"), "When using this apparatus, you gain a +3 item bonus to Crafting checks to Craft, Earn Income, and Repair, and you reduce the minimum time required to Craft an item to 1 day. If you succeed at your Crafting check and spend more downtime to continue work on the item after the minimum number of days, each day you spend reduces the remaining raw material cost by an amount based on your level + 1 and your proficiency rank in Crafting; on a critical success, each day reduces the remaining raw material cost by an amount based on your level + 2 and your proficiency rank. If you are 20th level, on a critical success your progress is 50 gp, 100 gp, 200 gp, or 350 gp for trained, expert, master, or legendary proficiency, respectively.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("47c995f5-7ecd-4762-b003-66817f6599a8"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("c58b11b6-4f32-40b2-89d2-e2e090374d45"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("8198cc5b-3275-46b4-a272-931ce5dccc15"), Traits.Instances.Transmutation.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("eefcc110-a3d7-4595-8497-7bd3cb794a35"),
				Name = "Inexplicable Apparatus",
                Usage = "Worn garment",
				Level = 18,
				Price = 1900000,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("258926a5-553e-49bb-97a0-f632d6103059"), ActionTypes.Instances.TwoActions.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Command, Interact")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("79bddc86-aced-4c3f-af50-a692de68c33a"), "You command the apparatus to magically jury-rig an item you hold or that�s within 5 feet of you. The item is repaired, as a 3rd-level mending spell. This lasts for 10 minutes, after which the item returns to its previous state of disrepair unless you�ve Repaired it before then.");
                            });
                    })
                    .Build()
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("152d7fd7-9f78-49e0-91f9-53b88771d5be"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 612
            };
        }
    }
}
